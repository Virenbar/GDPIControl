using GDPIControl.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormBlacklist : Form
    {
        private readonly HttpClient Client = new();
        private readonly Dictionary<RadioButton, string> RBtoURI = new();
        private CancellationTokenSource CTS;

        public FormBlacklist()
        {
            InitializeComponent();
            this.BindSettings();
            RBtoURI.Add(RB_AZ, @"https://antizapret.prostovpn.org/domains-export.txt");
            RBtoURI.Add(RB_AZ1, @"https://p.thenewone.lol/domains-export.txt");
            RBtoURI.Add(RB_AZ2, @"https://mirror.thetahex.ru/?key=blacklist-gdpi");
            RBtoURI.Add(RB_AF, @"https://antifilter.download/list/domains.lst");

            Client.DefaultRequestHeaders.Add("Origin", "GDPIControl");
        }

        #region UI Events

        private async void B_Download_Click(object sender, EventArgs e)
        {
            B_Download.Enabled = false;
            CTS = new CancellationTokenSource();
            try
            {
                var uri = RBtoURI.First(KV => KV.Key.Checked).Value;
                if (File.Exists(Constants.BlacklistTempPath)) { File.Delete(Constants.BlacklistTempPath); }

                var progress = new Progress<float>(p => PB.Value = (int)(p * 100));
                using (var FS = new FileStream(Constants.BlacklistTempPath, FileMode.Create))
                {
                    await Client.DownloadAsync(uri, FS, progress, CTS.Token);
                }
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
                CTS.Dispose();
                CTS = null;
                B_Download.Enabled = true;
            }
        }

        private void FormBlacklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            CTS?.Cancel();
            Client.Dispose();
        }

        #endregion UI Events
    }
}