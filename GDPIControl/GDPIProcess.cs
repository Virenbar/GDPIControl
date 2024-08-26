using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace GDPIControl
{
    internal static class GDPIProcess
    {
        private static Process GDPIP;

        public static bool IsRunning => GDPIP != null;

        public static async Task Restart()
        {
            Stop();
            await Task.Delay(5 * 1000);
            Start();
        }

        public static void Start()
        {
            if (IsRunning) { return; }
            var StartInfo = new ProcessStartInfo
            {
                FileName = Constants.GDPIPath,
                Arguments = Config.Current.Arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            GDPIP = new Process { StartInfo = StartInfo };
            GDPIP.EnableRaisingEvents = true;
            GDPIP.OutputDataReceived += GDPIP_OutputDataReceived;
            GDPIP.ErrorDataReceived += GDPIP_ErrorDataReceived;
            GDPIP.Start();
            GDPIP.BeginOutputReadLine();
            GDPIP.BeginErrorReadLine();
        }

        public static void Stop()
        {
            if (!IsRunning) { return; }
            GDPIP.Kill();
            GDPIP = null;
        }

        public static void StopDriver()
        {
            var devices = ServiceController.GetDevices();
            var driver = devices.FirstOrDefault(S => S.ServiceName.Contains("WinDivert"));
            driver?.Stop();
        }

        private static void GDPIP_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Debug.WriteLine(e.Data);
        }

        private static void GDPIP_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Debug.WriteLine(e.Data);
        }
    }
}