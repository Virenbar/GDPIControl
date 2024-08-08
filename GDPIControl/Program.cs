using System;
using System.Threading;
using System.Windows.Forms;

namespace GDPIControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using Mutex mutex = new(true, "GDPIControl", out var created);
#if NET6_0_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!created)
            {
                MessageBox.Show($"Another instance of {Application.ProductName} is already running.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Config.Load();
            var Form = new FormMain();
            if (!Config.Current.LaunchMinimazed) { Form.Show(); }

            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Config.Save();
        }
    }
}