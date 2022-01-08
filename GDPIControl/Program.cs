using System;
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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