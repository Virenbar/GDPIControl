using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormBlacklist : Form
    {
        private readonly WebClient Client = new();
        private readonly Dictionary<RadioButton, string> RBtoURI = new();

        public FormBlacklist()
        {
            InitializeComponent();
            RBtoURI.Add(RB_AZ, @"https://antizapret.prostovpn.org/domains-export.txt");
            RBtoURI.Add(RB_AZM, @"https://mirror.virenbar.workers.dev/?key=blacklist-gdpi");
            RBtoURI.Add(RB_AF, @"https://antifilter.download/list/domains.lst");

            Client.Headers.Add("Origin", "GDPIControl");
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PB.Value = e.ProgressPercentage;
            L_Size.Text = $"{Math.Round((double)e.TotalBytesToReceive / 1024, 2)} КВ";
            L_Done.Text = $"{Math.Round((double)e.BytesReceived / 1024, 2)} КВ";
        }

        #region UI Events

        private async void B_Download_Click(object sender, EventArgs e)
        {
            B_Download.Enabled = false;
            try
            {
                var uri = RBtoURI.First(KV => KV.Key.Checked).Value;
                if (File.Exists(Constants.BlacklistTempPath)) { File.Delete(Constants.BlacklistTempPath); }
                await Client.DownloadFileTaskAsync(new Uri(uri), Constants.BlacklistTempPath);
                if (File.Exists(Constants.BlacklistPath)) { File.Delete(Constants.BlacklistPath); }
                File.Move(Constants.BlacklistTempPath, Constants.BlacklistPath);
                this.ShowInfo("Blacklist download done");
            }
            catch (Exception E)
            {
                this.ShowError(E, "Download Error");
            }
            finally
            {
                B_Download.Enabled = true;
            }
        }

        private void FormBlacklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Client.IsBusy) { Client.CancelAsync(); }
            Client.Dispose();
        }

        #endregion UI Events
    }
}