using GDPIControl.Extensions;
using GDPIControl.Forms;
using GDPIControl.Model;
using GDPIControl.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDPIControl
{
    public partial class FormMain : Form
    {
        private readonly HashSet<Modeset> CustomModesets;
        private readonly List<(RadioButton Button, Modeset Modeset)> RBModesets;
        private readonly ControlSettings Settings = Config.Current;

        public FormMain()
        {
            InitializeComponent();
            this.BindSettings();
            CustomModesets = new() {
                Modeset.Custom1,
                Modeset.Custom2,
                Modeset.Custom3
            };
            RBModesets = new List<(RadioButton Button, Modeset Modeset)>
            {
                (RB_M1,Modeset.M1),
                (RB_M2,Modeset.M2),
                (RB_M3,Modeset.M3),
                (RB_M4,Modeset.M4),
                (RB_M5,Modeset.M5),
                (RB_M6,Modeset.M6),
                (RB_M7,Modeset.M7),
                (RB_M8,Modeset.M8),
                (RB_M9,Modeset.M9),
                (RB_Custom_1,Modeset.Custom1),
                (RB_Custom_2,Modeset.Custom2),
                (RB_Custom_3,Modeset.Custom3)
            };
            RBModesets.First(X => X.Modeset == Settings.Modeset).Button.Checked = true;
            BS_ControlSettings.DataSource = Settings;

            RefreshUI();
            RefreshArguments();
            if (Settings.AutostartGDPI) { StartGDPI(); } else { StopGDPI(); }
        }

        private void CloseGDPIControl()
        {
            GDPIProcess.Stop();
            TrayControl.Icon = null;
            TrayControl.Visible = false;
            TrayControl.Dispose();
            RefreshArguments();
            if (Settings.StopDriver)
            {
                GDPIProcess.StopDriver();
            }
            Application.Exit();
        }

        private void RefreshArguments()
        {
            Settings.Modeset = RBModesets.First(X => X.Button.Checked).Modeset;
            var Arguments = Settings.Modeset.ToArgument();
            if (Settings.UseBlacklist) { Arguments += $@" --blacklist ""{Constants.BlacklistPath}"""; }
            if (Settings.UseUserlist) { Arguments += $@" --blacklist ""{Constants.UserlistPath}"""; }
            Settings.Arguments = Arguments;
        }

        private void RefreshUI()
        {
            B_Edit.Enabled = CustomModesets.Contains(Settings.Modeset);
            B_Restart.Enabled = GDPIProcess.IsRunning;
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
            RefreshArguments();
            GDPIProcess.Start();
            RefreshUI();
        }

        private void StopGDPI()
        {
            B_Start.Text = "Start GDPI";
            B_Start.Image = Resources.GDPI_green;
            MI_Start.Enabled = true;
            MI_Stop.Enabled = false;
            TrayControl.Icon = Resources.icon_red;
            Icon = Resources.icon_red;
            RefreshArguments();
            GDPIProcess.Stop();
            RefreshUI();
        }

        private void UIState(bool state)
        {
            B_Restart.Enabled = state;
            B_Start.Enabled = state;
            B_Close.Enabled = state;
        }

        #region UIEvents

        private void B_Close_Click(object sender, EventArgs e) => CloseGDPIControl();

        private void B_Edit_Click(object sender, EventArgs e)
        {
            using var form = new FormGDPISettings(Settings);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshArguments();
            }
        }

        private async void B_Restart_Click(object sender, EventArgs e)
        {
            UIState(false);
            StopGDPI();
            await Task.Delay(500);
            StartGDPI();
            UIState(true);
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            UIState(false);
            if (GDPIProcess.IsRunning) { StopGDPI(); } else { StartGDPI(); }
            UIState(true);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }
            e.Cancel = true;
            Visible = false;
        }

        private void MI_About_Click(object sender, EventArgs e)
        {
            var F = new FormAbout();
            F.ShowDialog(this);
        }

        private void MI_Settings_Click(object sender, EventArgs e)
        {
            using var F = new FormSettings();
            F.ShowDialog(this);
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            var RB = (RadioButton)sender;
            if (!RB.Checked) { return; }
            foreach (var entry in RBModesets)
            {
                if (entry.Button == RB) { continue; }
                entry.Button.Checked = false;
            }
            RefreshArguments();
            RefreshUI();
        }

        #region Lists

        private void MI_Blacklist_Click(object sender, EventArgs e)
        {
            var F = new FormBlacklist();
            F.ShowDialog(this);
        }

        private void MI_Userlist_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Constants.UserlistPath))
            {
                File.WriteAllText(Constants.UserlistPath, "");
            }
            Process.Start(new ProcessStartInfo(Constants.UserlistPath) { UseShellExecute = true });
        }

        #endregion Lists

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