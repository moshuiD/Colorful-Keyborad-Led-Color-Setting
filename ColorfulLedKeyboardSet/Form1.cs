using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorfulLedKeyboardSet
{
    public partial class Form1 : Form
    {
        [DllImport("InsydeDCHU.dll")]
        public static extern int SetDCHU_Data(int command, byte[] buffer, int length);

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void SetColor(int KbPart, Color _color)
        {
            int num = 0;
            switch (KbPart)
            {
                case 1:
                    num = 240;
                    break;
                case 2:
                    num = 241;
                    break;
                case 3:
                    num = 242;
                    break;
                case 7:
                    num = 246;
                    break;
                case 8:
                    num = 243;
                    break;
            }
            uint num2;
            num2 = (uint)((int)_color.B << 16 | (int)_color.R << 8 | (int)_color.G);
            if (_color.R == 0 && _color.G == 255 && _color.B == 127)
            {
                num2 = (uint)(4587520 | (int)_color.R << 8 | (int)_color.G);
            }


            byte[] bytes = BitConverter.GetBytes((long)((long)num << 24) + (long)((ulong)num2));
            SetDCHU_Data(103, bytes, 4);
            ColorTestLabel.ForeColor = _color;
        }
        int r = 255;
        int g = 0;
        int b = 0;
        Thread LoopThread;
        private void RGBLoop()
        {
            while (true)
            {
                if (!(g == 255 && r == 0 && b == 255))
                {
                    for (; g < 255; g += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    g = g > 255 ? g = 255 : g;
                    for (; r > 0; r -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    r = r < 0 ? r = 0 : r;
                    for (; b < 255; b += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    b = b > 255 ? b = 255 : b;
                }
                else
                {
                    for (; g > 0; g -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    g = g < 0 ? g = 0 : g;
                    for (; r < 255; r += speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    r = r > 255 ? r = 255 : r;
                    for (; b > 0; b -= speedBar.Value)
                    {

                        SetColor(1, Color.FromArgb(r, g, b));
                        SetColor(2, Color.FromArgb(r, g, b));
                        SetColor(3, Color.FromArgb(r, g, b));
                    }
                    b = b < 0 ? b = 0 : b;
                }
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            LoopThread = new Thread(new ThreadStart(() => this.RGBLoop()));
            LoopThread.IsBackground = true;
            LoopThread.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\InsydeDCHU.dll"))
            {
                MessageBox.Show("发生错误:InsydeDCHU.dll缺失\r\n，请检查程序运行文件夹下是否有InsydeDCHU.dll", "发生错误");
                Environment.Exit(0);
            }
            MessageBox.Show("此程序为墨水制作\r\n利用逆向手段获取API编写而成\r\n有任何硬件问题开发者不承担任何责任！", "免责声明");
            button2.Enabled = false;
        }

        private void CustomRGB_B_Click(object sender, EventArgs e)
        {
            if(LoopThread!=null)
            LoopThread.Abort();
            button1.Enabled = true;
            button2.Enabled = false;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SetColor(1, colorDialog1.Color);
                SetColor(2, colorDialog1.Color);
                SetColor(3, colorDialog1.Color);
            }
        }

        private void information_B_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你好，我是墨水\r\n这个程序是写给七彩虹笔记本（有可能神舟也可以）用户的\r\n" +
                 "由于我发现这款电脑虽能设置键盘灯光\r\n但无法RGB循环以及自定义RGB\r\n故诞生了此程序\r\n" +
                 "使用循环RGB模式可以拖动滑动条调整循环速度\r\n更多信息前往此项目Github仓库查看!\r\n" +
                 "是否自动打开此程序Github仓库？", "一些信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("https://github.com/moshuiD/Colorful-Keyborad-Led-Color-Setting");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoopThread.Abort();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void GetSource_L_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/moshuiD/Colorful-Keyborad-Led-Color-Setting");
        }
    }
}
