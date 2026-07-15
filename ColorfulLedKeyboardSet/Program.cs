using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorfulLedKeyboardSet
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool startMinimized = false;
            if (args != null && args.Length > 0)
            {
                foreach (var arg in args)
                {
                    if (arg.Equals("-minimized", StringComparison.OrdinalIgnoreCase))
                    {
                        startMinimized = true;
                    }
                }
            }

            Application.Run(new Form1(startMinimized));
        }
    }
}
