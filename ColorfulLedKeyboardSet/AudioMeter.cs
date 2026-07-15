using System;
using System.Runtime.InteropServices;

namespace ColorfulLedKeyboardSet
{
    // ============================================================
    // 音频峰值电平计 — 基于 Windows Core Audio (WASAPI) COM 接口
    // 用于"音乐律动"模式，实时获取系统音频输出的峰值音量
    // 零外部依赖，仅使用 Windows 内置 COM 接口
    // ============================================================

    // 音频数据流方向枚举
    internal enum EDataFlow
    {
        eRender = 0,    // 播放设备（扬声器/耳机）
        eCapture = 1,   // 录音设备（麦克风）
        eAll = 2
    }

    // 音频设备角色枚举
    internal enum ERole
    {
        eConsole = 0,
        eMultimedia = 1,
        eCommunications = 2
    }

    // IMMDeviceEnumerator — 音频设备枚举器接口
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface IMMDeviceEnumerator
    {
        int EnumAudioEndpoints(EDataFlow dataFlow, int dwStateMask, out IntPtr ppDevices);
        int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);
    }

    // IMMDevice — 单个音频设备接口
    [Guid("D666063F-1587-4E43-81F1-B948E807363F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface IMMDevice
    {
        int Activate([In] ref Guid iid, [In] int dwClsCtx, [In] IntPtr pActivationParams,
                     [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
    }

    // IAudioMeterInformation — 音频峰值电平信息接口
    [Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    internal interface IAudioMeterInformation
    {
        int GetPeakValue(out float pfPeak);
    }

    // MMDeviceEnumerator COM 类实例化入口
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    [ComImport]
    internal class MMDeviceEnumeratorComObject { }

    /// <summary>
    /// 音频峰值电平计
    /// 通过 WASAPI 获取系统默认音频输出设备的实时峰值音量 (0.0 ~ 1.0)
    /// 无需录音权限，无需外部库
    /// </summary>
    public class AudioMeter : IDisposable
    {
        private IMMDeviceEnumerator deviceEnumerator;
        private IMMDevice device;
        private IAudioMeterInformation meterInfo;
        private bool disposed = false;

        private AudioMeter(IMMDeviceEnumerator enumerator, IMMDevice dev, IAudioMeterInformation meter)
        {
            this.deviceEnumerator = enumerator;
            this.device = dev;
            this.meterInfo = meter;
        }

        /// <summary>
        /// 尝试创建音频电平计实例。如果系统没有音频设备或初始化失败，返回 null
        /// </summary>
        public static AudioMeter TryCreate()
        {
            try
            {
                // 创建设备枚举器 COM 对象
                var enumeratorObj = new MMDeviceEnumeratorComObject();
                var enumerator = (IMMDeviceEnumerator)enumeratorObj;

                // 获取默认音频播放设备
                IMMDevice device;
                int hr = enumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out device);
                if (hr != 0 || device == null)
                {
                    Marshal.ReleaseComObject(enumeratorObj);
                    return null;
                }

                // 激活 IAudioMeterInformation 接口
                Guid iidMeter = typeof(IAudioMeterInformation).GUID;
                object meterObj;
                hr = device.Activate(ref iidMeter, 1 /* CLSCTX_INPROC_SERVER */, IntPtr.Zero, out meterObj);
                if (hr != 0 || meterObj == null)
                {
                    Marshal.ReleaseComObject(device);
                    Marshal.ReleaseComObject(enumeratorObj);
                    return null;
                }

                return new AudioMeter(enumerator, device, (IAudioMeterInformation)meterObj);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取当前音频峰值电平 (0.0 ~ 1.0)
        /// 0.0 = 静音, 1.0 = 满电平
        /// </summary>
        public float GetPeakValue()
        {
            if (disposed || meterInfo == null) return 0f;

            try
            {
                float peak;
                int hr = meterInfo.GetPeakValue(out peak);
                if (hr == 0 && peak >= 0f && peak <= 1f)
                    return peak;
                return 0f;
            }
            catch
            {
                return 0f;
            }
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;

            try
            {
                if (meterInfo != null) Marshal.ReleaseComObject(meterInfo);
                if (device != null) Marshal.ReleaseComObject(device);
                if (deviceEnumerator != null) Marshal.ReleaseComObject(deviceEnumerator);
            }
            catch { }

            meterInfo = null;
            device = null;
            deviceEnumerator = null;
        }
    }
}
