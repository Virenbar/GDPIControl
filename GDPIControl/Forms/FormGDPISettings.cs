using GDPIControl.Model;
using System;
using System.Windows.Forms;

namespace GDPIControl.Forms
{
    public partial class FormGDPISettings : Form
    {
        private readonly GDPISettings GDPISettings;
        private readonly ControlSettings Settings;

        public FormGDPISettings(ControlSettings settings)
        {
            InitializeComponent();
            Settings = settings;
            GDPISettings = (GDPISettings)(Settings.Modeset switch
            {
                Modeset.Custom1 => settings.CustomSettings1,
                Modeset.Custom2 => settings.CustomSettings2,
                Modeset.Custom3 => settings.CustomSettings3,
                _ => default
            }).Clone();
            BS_GDPISettings.DataSource = GDPISettings;
        }

        #region UIEvents

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            _ = Settings.Modeset switch
            {
                Modeset.Custom1 => Settings.CustomSettings1 = GDPISettings,
                Modeset.Custom2 => Settings.CustomSettings2 = GDPISettings,
                Modeset.Custom3 => Settings.CustomSettings3 = GDPISettings,
                _ => throw new InvalidOperationException()
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormGDPISettings_Load(object sender, EventArgs e)
        {
            Icon = Owner.Icon;
        }

        #endregion UIEvents
    }
}