using System;
using System.Drawing;
using System.Management;

namespace ColorfulLedKeyboardSet
{
    // ============================================================
    // CPU 温度 / 负载监控器
    // 优先使用 WMI 读取真实 CPU 温度（需管理员权限）
    // 无权限时自动降级为 CPU 负载百分比模式
    // 零外部依赖，仅使用 .NET Framework 内置 System.Management
    // ============================================================

    /// <summary>
    /// CPU 温度/负载监控器，支持优雅降级
    /// </summary>
    public class TemperatureMonitor : IDisposable
    {
        /// <summary>是否读取到了真实温度（false 表示使用 CPU 负载近似）</summary>
        public bool IsRealTemperature { get; private set; }

        /// <summary>当前状态文本，用于 UI 显示（如 "CPU 温度: 65°C"）</summary>
        public string StatusText { get; private set; }

        private ManagementObjectSearcher wmiSearcher;
        private ManagementObjectSearcher cpuLoadSearcher;
        private bool disposed = false;
        private bool useWmiTemp = false;
        private float lastCpuLoad = 0f;
        private bool cpuLoadFirstCall = true;

        public TemperatureMonitor()
        {
            StatusText = "初始化中...";
            IsRealTemperature = false;

            // 尝试初始化 WMI 真实温度查询（需管理员权限访问 root\WMI）
            try
            {
                var scope = new ManagementScope(@"root\WMI");
                scope.Connect();

                wmiSearcher = new ManagementObjectSearcher(scope,
                    new ObjectQuery("SELECT CurrentTemperature FROM MSAcpi_ThermalZoneTemperature"));

                // 测试查询是否能成功执行
                using (var results = wmiSearcher.Get())
                {
                    foreach (ManagementObject obj in results)
                    {
                        var raw = Convert.ToDouble(obj["CurrentTemperature"]);
                        double celsius = (raw / 10.0) - 273.15;
                        if (celsius > -20 && celsius < 150) // 合理温度范围检查
                        {
                            useWmiTemp = true;
                            IsRealTemperature = true;
                            break;
                        }
                    }
                }
            }
            catch
            {
                // WMI 温度不可用（非管理员或硬件不支持），使用降级方案
                useWmiTemp = false;
                if (wmiSearcher != null) { wmiSearcher.Dispose(); wmiSearcher = null; }
            }

            // 初始化 CPU 负载查询作为降级/备用方案
            if (!useWmiTemp)
            {
                try
                {
                    cpuLoadSearcher = new ManagementObjectSearcher(
                        "SELECT LoadPercentage FROM Win32_Processor");
                    IsRealTemperature = false;
                    StatusText = "温度读取受限，已切换为CPU负载模式";
                }
                catch
                {
                    StatusText = "硬件监控初始化失败";
                }
            }
        }

        /// <summary>
        /// 获取标准化数值 (0.0 ~ 100.0)
        /// 如果是真实温度：30°C=0, 95°C=100
        /// 如果是CPU负载：直接返回 0~100
        /// </summary>
        public double GetNormalizedValue()
        {
            if (disposed) return 50.0;

            try
            {
                if (useWmiTemp && wmiSearcher != null)
                {
                    return ReadWmiTemperature();
                }
                else if (cpuLoadSearcher != null)
                {
                    return ReadCpuLoad();
                }
            }
            catch
            {
                StatusText = "读取异常，使用默认值";
            }

            return 50.0; // 安全默认值
        }

        private double ReadWmiTemperature()
        {
            double celsius = 50.0;
            try
            {
                using (var results = wmiSearcher.Get())
                {
                    foreach (ManagementObject obj in results)
                    {
                        var raw = Convert.ToDouble(obj["CurrentTemperature"]);
                        celsius = (raw / 10.0) - 273.15;
                        break; // 取第一个热区
                    }
                }
            }
            catch
            {
                // WMI 查询可能在运行时突然失败，降级
                useWmiTemp = false;
                IsRealTemperature = false;
                StatusText = "温度读取中断，已切换为CPU负载模式";
                return 50.0;
            }

            // 将温度映射到 0~100 标准化范围 (30°C~95°C)
            double normalized = (celsius - 30.0) / (95.0 - 30.0) * 100.0;
            normalized = Math.Max(0.0, Math.Min(100.0, normalized));

            StatusText = string.Format("CPU 温度: {0:F0}°C", celsius);
            return normalized;
        }

        private double ReadCpuLoad()
        {
            double load = lastCpuLoad;
            try
            {
                using (var results = cpuLoadSearcher.Get())
                {
                    foreach (ManagementObject obj in results)
                    {
                        load = Convert.ToDouble(obj["LoadPercentage"]);
                        break;
                    }
                }

                // 第一次调用可能返回0，跳过
                if (cpuLoadFirstCall)
                {
                    cpuLoadFirstCall = false;
                    lastCpuLoad = (float)load;
                }
                else
                {
                    lastCpuLoad = (float)load;
                }
            }
            catch
            {
                // 使用上次的值
            }

            StatusText = string.Format("CPU 负载: {0:F0}%", load);
            return Math.Max(0.0, Math.Min(100.0, load));
        }

        /// <summary>
        /// 将标准化温度/负载值 (0~100) 映射为渐变颜色
        /// 冰蓝 → 青绿 → 暖黄 → 橙色 → 烈红
        /// </summary>
        public static Color MapToColor(double normalizedValue)
        {
            double v = Math.Max(0.0, Math.Min(100.0, normalizedValue));

            // 颜色锚点定义
            // 0~25:   冰蓝(0,150,255) → 青绿(0,255,150)
            // 25~55:  青绿(0,255,150) → 暖黄(255,200,0)
            // 55~75:  暖黄(255,200,0) → 橙色(255,100,0)
            // 75~100: 橙色(255,100,0) → 烈红(255,0,0)

            if (v <= 25)
            {
                double t = v / 25.0;
                return Lerp(0, 150, 255, 0, 255, 150, t);
            }
            else if (v <= 55)
            {
                double t = (v - 25) / 30.0;
                return Lerp(0, 255, 150, 255, 200, 0, t);
            }
            else if (v <= 75)
            {
                double t = (v - 55) / 20.0;
                return Lerp(255, 200, 0, 255, 100, 0, t);
            }
            else
            {
                double t = (v - 75) / 25.0;
                return Lerp(255, 100, 0, 255, 0, 0, t);
            }
        }

        // 线性插值辅助函数
        private static Color Lerp(int r1, int g1, int b1, int r2, int g2, int b2, double t)
        {
            t = Math.Max(0.0, Math.Min(1.0, t));
            int r = (int)(r1 + (r2 - r1) * t);
            int g = (int)(g1 + (g2 - g1) * t);
            int b = (int)(b1 + (b2 - b1) * t);
            return Color.FromArgb(
                Math.Max(0, Math.Min(255, r)),
                Math.Max(0, Math.Min(255, g)),
                Math.Max(0, Math.Min(255, b)));
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;

            if (wmiSearcher != null) { wmiSearcher.Dispose(); wmiSearcher = null; }
            if (cpuLoadSearcher != null) { cpuLoadSearcher.Dispose(); cpuLoadSearcher = null; }
        }
    }
}
