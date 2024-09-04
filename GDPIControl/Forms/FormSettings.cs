using GDPIControl.Extensions;
using GDPIControl.Model;
using System;
using System.Windows.Forms;

namespace GDPIControl.Forms
{
    public partial class FormSettings : Form
    {
        private readonly ControlSettings Settings = Config.Current;

        public FormSettings()
        {
            InitializeComponent();
            this.BindSettings();
            CB_Minimized.Checked = Settings.LaunchMinimazed;
            CB_AutostartGDPIControl.Checked = ControlTask.IsRegistered;

            CB_AutostartGDPI.Checked = Settings.AutostartGDPI;
            CB_StopDriver.Checked = Settings.StopDriver;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            Settings.LaunchMinimazed = CB_Minimized.Checked;
            Settings.AutostartGDPI = CB_AutostartGDPI.Checked;
            Settings.StopDriver = CB_StopDriver.Checked;

            try
            {
                if (CB_AutostartGDPIControl.Checked && !ControlTask.IsRegistered)
                {
                    ControlTask.Register();
                }
                else if (!CB_AutostartGDPIControl.Checked && ControlTask.IsRegistered)
                {
                    ControlTask.Delete();
                }
            }
            catch (Exception ex)
            {
                this.ShowError(ex);
            }
            Close();
        }
    }
}