using System.Diagnostics;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            L_Version.Text = $"v{Application.ProductVersion}";
        }

        private static void OpenURL(string url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        private void LL_Control_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_Control.LinkVisited = true;
            OpenURL("https://github.com/Virenbar/GDPIControl");
        }

        private void LL_GDPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_GDPI.LinkVisited = true;
            OpenURL("https://github.com/ValdikSS/GoodbyeDPI/");
        }

        private void LL_Icons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_Icons.LinkVisited = true;
            OpenURL("https://icons8.com");
        }

        private void LL_WinDivert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_WinDivert.LinkVisited = true;
            OpenURL("https://github.com/basil00/Divert");
        }
    }
}