using GDPIControl.Model;
using GDPIControl.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormMain : Form
    {
        private readonly Regex IP_R = new(@"^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])$");
        private readonly List<(RadioButton Button, Modeset Modeset)> RBModesets;
        private readonly ControlSettings Settings = Config.Current;

        public FormMain()
        {
            InitializeComponent();
            RBModesets = new List<(RadioButton Button, Modeset Modeset)>
            {
                (RB_M1,Modeset.M1),
                (RB_M2,Modeset.M2),
                (RB_M3,Modeset.M3),
                (RB_M4,Modeset.M4),
                (RB_M5,Modeset.M5),
                (RB_M6,Modeset.M6),
                (RB_Custom,Modeset.Custom)
            };
            RBModesets.First(X => X.Modeset == Settings.Modeset).Button.Checked = true;
            MI_Autostart.Checked = Settings.AutostartGDPI;
            MI_Minimized.Checked = Settings.LaunchMinimazed;
            MI_Logon.Checked = ControlTask.IsRegistered;

            BS_ControlSettings.DataSource = Settings;
            BS_GDPISettings.DataSource = Settings.GDPISettings;

            SetArguments();
            if (Settings.AutostartGDPI) { StartGDPI(); } else { StopGDPI(); }
        }

        private void CloseGDPIControl()
        {
            GDPIProcess.Stop();
            TrayControl.Icon = null;
            TrayControl.Visible = false;
            TrayControl.Dispose();
            SetArguments();
            Application.Exit();
        }

        private void SetArguments()
        {
            string Arguments;
            Settings.Modeset = RBModesets.First(X => X.Button.Checked).Modeset;
            if (Settings.Modeset == Modeset.Custom)
            {
                Arguments = Settings.GDPISettings.ToArguments();
            }
            else
            {
                Arguments = GDPISettings.ModesetArgument(Settings.Modeset);
            }
            if (Settings.UseBlacklist) { Arguments += $" --blacklist {Constants.BlacklistName}"; }
            if (Settings.UseUserlist) { Arguments += $" --blacklist {Constants.UserlistName}"; }
            Settings.Arguments = Arguments;

            B_Copy.Enabled = Settings.Modeset != Modeset.Custom;
        }

        private void ShowGDPIControl()
        {
            Show();
            Activate();
        }

        private void StartGDPI()
        {
            B_Start.Text = "Stop GDPI";
            B_Start.Image = Resources.GDPI_red;
            MI_Start.Enabled = false;
            MI_Stop.Enabled = true;
            TrayControl.Icon = Resources.icon_green;
            Icon = Resources.icon_green;
            SetArguments();
            GDPIProcess.Start();
        }

        private void StopGDPI()
        {
            B_Start.Text = "Start GDPI";
            B_Start.Image = Resources.GDPI_green;
            MI_Start.Enabled = true;
            MI_Stop.Enabled = false;
            TrayControl.Icon = Resources.icon_red;
            Icon = Resources.icon_red;
            SetArguments();
            GDPIProcess.Stop();
        }

        #region UIEvents

        private void B_Close_Click(object sender, EventArgs e) => CloseGDPIControl();

        private void B_Copy_Click(object sender, EventArgs e)
        {
            Settings.GDPISettings = GDPISettings.ModesetSettings(Settings.Modeset);
            RB_Custom.Checked = true;
            TC_Main.SelectedTab = TP_Custom;
            BS_GDPISettings.DataSource = Settings.GDPISettings;
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            if (GDPIProcess.IsRunning) { StopGDPI(); } else { StartGDPI(); }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }
            e.Cancel = true;
            Visible = false;
        }

        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            TP_Custom.SuspendLayout();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            TP_Custom.ResumeLayout();
        }

        private void MI_About_Click(object sender, EventArgs e)
        {
            var F = new FormAbout();
            F.ShowDialog(this);
        }

        private void RB_CheckedChanged(object sender, EventArgs e) => SetArguments();

        #region Lists

        private void MI_Blacklist_Click(object sender, EventArgs e)
        {
            var F = new FormBlacklist();
            F.ShowDialog(this);
        }

        private void MI_Userlist_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Constants.UserlistPath)) { File.WriteAllText(Constants.UserlistPath, ""); }
            Process.Start(new ProcessStartInfo(Constants.UserlistPath) { UseShellExecute = true });
        }

        #endregion Lists

        #region Control settings

        private void MI_Autostart_CheckedChanged(object sender, EventArgs e)
        {
            Config.Current.AutostartGDPI = MI_Autostart.Checked;
        }

        private void MI_Logon_Click(object sender, EventArgs e)
        {
            if (!ControlTask.IsRegistered)
            {
                ControlTask.Register();
            }
            else
            {
                ControlTask.Delete();
            }
            MI_Logon.Checked = ControlTask.IsRegistered;
        }

        private void MI_Minimized_CheckedChanged(object sender, EventArgs e)
        {
            Config.Current.LaunchMinimazed = MI_Minimized.Checked;
        }

        #endregion Control settings

        #region Validating
        /*
        Private Sub DNS_IP_Validating(sender As Object, e As CancelEventArgs) Handles DNS_IP.Validating
            If DNS_IP.Text = "" Then Exit Sub
            Try
                Dim M = IP_R.Match(DNS_IP.Text)
                e.Cancel = Not M.Success
            Catch ex As Exception
                e.Cancel = True
            End Try
        End Sub

        Private Sub DNS_Port_Validating(sender As Object, e As CancelEventArgs) Handles DNS_Port.Validating
            Try
                Dim p = CInt(DNS_Port.Text)
                e.Cancel = p <= 0 Or p > 65535
            Catch ex As Exception
                e.Cancel = True
            End Try
        End Sub

        Private Sub DNS6_IP_Validating(sender As Object, e As CancelEventArgs) Handles DNS6_IP.Validating
            If DNS6_IP.Text = "" Then Exit Sub
            Try
                Dim IP As IPAddress = Nothing
                Dim r = IPAddress.TryParse(DNS6_IP.Text, IP)
                Dim T = IP.AddressFamily
            Catch ex As Exception
                e.Cancel = True
            End Try
        End Sub

        Private Sub DNS6_Port_Validating(sender As Object, e As CancelEventArgs) Handles DNS6_Port.Validating
            Try
                Dim p = CInt(DNS6_Port.Text)
                e.Cancel = p <= 0 Or p > 65535
            Catch ex As Exception
                e.Cancel = True
            End Try
        End Sub
        */
        #endregion Validating

        #region Tray

        private void MI_Close_Click(object sender, EventArgs e) => CloseGDPIControl();

        private void MI_Show_Click(object sender, EventArgs e) => ShowGDPIControl();

        private void MI_Start_Click(object sender, EventArgs e) => StartGDPI();

        private void MI_Stop_Click(object sender, EventArgs e) => StopGDPI();

        private void TrayControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { ShowGDPIControl(); }
        }

        #endregion Tray

        #endregion UIEvents
    }
}