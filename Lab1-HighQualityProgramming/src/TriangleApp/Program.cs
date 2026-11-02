using System;
using System.Windows.Forms;

namespace TriangleApp
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序主入口。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
