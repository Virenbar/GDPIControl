using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormBlacklist : Form
    {
        private readonly WebClient Client = new();

        public FormBlacklist()
        {
            InitializeComponent();
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PB.Value = e.ProgressPercentage;
            L_Size.Text = $"{Math.Round((double)e.TotalBytesToReceive / 1024, 2)} КВ";
            L_Done.Text = $"{Math.Round((double)e.BytesReceived / 1024, 2)} КВ";
        }

        private async void FormBlacklist_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Constants.NewBlacklistPath)) { File.Delete(Constants.NewBlacklistPath); }
                await Client.DownloadFileTaskAsync(new Uri(Constants.BlacklistURI), Constants.NewBlacklistPath);
                if (File.Exists(Constants.BlacklistPath)) { File.Delete(Constants.BlacklistPath); }
                File.Move(Constants.NewBlacklistPath, Constants.BlacklistPath);
                MessageBox.Show("Blacklist download done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBlacklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Client.IsBusy) { Client.CancelAsync(); }
            Client.Dispose();
        }
    }
}