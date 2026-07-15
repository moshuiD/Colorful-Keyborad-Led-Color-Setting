using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorfulLedKeyboardSet
{
    // ============================================================
    // 屏幕主色调采样器 (高效 GDI+ Win32 硬件级拉伸版)
    // 用于"屏幕氛围灯"模式，截取屏幕画面并提取主要颜色
    // 通过 StretchBlt 直接从屏幕 DC 拉伸拷贝到 64x36 微型 Bitmap (仅9KB)
    // 完美解决普通 CopyFromScreen 生成全尺寸大图造成的内存抖动和 CPU 压力
    // ============================================================

    /// <summary>
    /// 屏幕主色调采样器
    /// 截取当前主屏幕画面，提取并增强主色调
    /// </summary>
    public static class ScreenColorSampler
    {
        // 缩小采样的目标尺寸（越小越快，64x36 约为 16:9）
        private const int SampleWidth = 64;
        private const int SampleHeight = 36;

        // 像素过滤阈值（排除纯黑边框和过曝高光）
        private const int DarkThreshold = 45;    // R+G+B 总和低于此值视为黑色
        private const int BrightThreshold = 720; // R+G+B 总和高于此值视为白色

        // Win32 API 声明
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern bool StretchBlt(
            IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest,
            IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc,
            int dwRop);

        private const int SRCCOPY = 0x00CC0020;

        /// <summary>
        /// 获取当前主屏幕的主色调（高性能版）
        /// </summary>
        /// <returns>增强饱和度后的主色调</returns>
        public static Color GetDominantColor()
        {
            Bitmap bitmap = null;
            Graphics g = null;
            IntPtr hdcSrc = IntPtr.Zero;
            IntPtr hdcDest = IntPtr.Zero;

            try
            {
                var bounds = Screen.PrimaryScreen.Bounds;
                int screenWidth = bounds.Width;
                int screenHeight = bounds.Height;

                // 创建小采样位图 (64x36 仅需 9KB 内存)
                bitmap = new Bitmap(SampleWidth, SampleHeight);
                g = Graphics.FromImage(bitmap);

                // 获取屏幕的设备上下文 (DC) 和 Graphics 的设备上下文
                hdcSrc = GetDC(IntPtr.Zero);
                hdcDest = g.GetHdc();

                // 直接在底层把屏幕画面缩放拷贝到 64x36 的位图中，跳过创建中间全屏大图
                StretchBlt(
                    hdcDest, 0, 0, SampleWidth, SampleHeight,
                    hdcSrc, bounds.X, bounds.Y, screenWidth, screenHeight,
                    SRCCOPY);

                // 释放 DC 句柄
                g.ReleaseHdc(hdcDest);
                hdcDest = IntPtr.Zero;

                ReleaseDC(IntPtr.Zero, hdcSrc);
                hdcSrc = IntPtr.Zero;

                // 遍历采样像素，计算有效像素的 RGB 均值
                long totalR = 0, totalG = 0, totalB = 0;
                int validCount = 0;

                for (int y = 0; y < SampleHeight; y++)
                {
                    for (int x = 0; x < SampleWidth; x++)
                    {
                        Color pixel = bitmap.GetPixel(x, y);
                        int sum = pixel.R + pixel.G + pixel.B;

                        // 过滤过暗（黑边）和过亮（高光）的像素
                        if (sum >= DarkThreshold && sum <= BrightThreshold)
                        {
                            totalR += pixel.R;
                            totalG += pixel.G;
                            totalB += pixel.B;
                            validCount++;
                        }
                    }
                }

                if (validCount == 0)
                {
                    // 全黑屏幕（可能息屏或全黑页面），返回深蓝默认色
                    return Color.FromArgb(0, 80, 160);
                }

                // 计算均值颜色
                Color avgColor = Color.FromArgb(
                    (int)(totalR / validCount),
                    (int)(totalG / validCount),
                    (int)(totalB / validCount));

                // 增强饱和度，让颜色更鲜艳生动
                return BoostSaturation(avgColor, 1.5);
            }
            catch
            {
                // 异常时返回安全默认色（深蓝色）
                return Color.FromArgb(0, 100, 200);
            }
            finally
            {
                // 确保在任何异常情况下都能释放句柄和对象，防止句柄泄露
                if (hdcDest != IntPtr.Zero && g != null)
                {
                    try { g.ReleaseHdc(hdcDest); } catch { }
                }
                if (hdcSrc != IntPtr.Zero)
                {
                    try { ReleaseDC(IntPtr.Zero, hdcSrc); } catch { }
                }
                if (g != null) g.Dispose();
                if (bitmap != null) bitmap.Dispose();
            }
        }

        /// <summary>
        /// 增强颜色饱和度
        /// </summary>
        /// <param name="color">原始颜色</param>
        /// <param name="factor">饱和度倍数（1.0=不变, >1.0=更鲜艳）</param>
        private static Color BoostSaturation(Color color, double factor)
        {
            // RGB → HSV 转换
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            double h = 0, s = 0, v = max;

            if (max > 0)
            {
                s = delta / max;
            }

            if (delta > 0)
            {
                if (max == r)
                    h = 60.0 * (((g - b) / delta) % 6);
                else if (max == g)
                    h = 60.0 * (((b - r) / delta) + 2);
                else
                    h = 60.0 * (((r - g) / delta) + 4);
            }

            if (h < 0) h += 360;

            // 增强饱和度
            s = Math.Min(1.0, s * factor);

            // HSV → RGB 转换
            return HsvToRgb(h, s, v);
        }

        private static Color HsvToRgb(double h, double s, double v)
        {
            int hi = ((int)(h / 60)) % 6;
            double f = h / 60.0 - Math.Floor(h / 60.0);

            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            double rr, gg, bb;
            switch (hi)
            {
                case 0: rr = v; gg = t; bb = p; break;
                case 1: rr = q; gg = v; bb = p; break;
                case 2: rr = p; gg = v; bb = t; break;
                case 3: rr = p; gg = q; bb = v; break;
                case 4: rr = t; gg = p; bb = v; break;
                default: rr = v; gg = p; bb = q; break;
            }

            return Color.FromArgb(
                Math.Max(0, Math.Min(255, (int)(rr * 255))),
                Math.Max(0, Math.Min(255, (int)(gg * 255))),
                Math.Max(0, Math.Min(255, (int)(bb * 255))));
        }
    }
}
