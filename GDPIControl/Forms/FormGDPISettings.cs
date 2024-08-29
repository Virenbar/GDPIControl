using GDPIControl.Extensions;
using GDPIControl.Model;
using System;
using System.Windows.Forms;

namespace GDPIControl.Forms
{
    public partial class FormGDPISettings : Form
    {
        private readonly ControlSettings Settings;
        private GDPISettings GDPISettings;

        public FormGDPISettings(ControlSettings settings)
        {
            InitializeComponent();
            this.BindSettings();
            Settings = settings;
            GDPISettings = (GDPISettings)(Settings.Modeset switch
            {
                Modeset.Custom1 => settings.CustomSettings1,
                Modeset.Custom2 => settings.CustomSettings2,
                Modeset.Custom3 => settings.CustomSettings3,
                _ => default
            }).Clone();
            BS_GDPISettings.CurrentItemChanged += BS_GDPISettings_CurrentItemChanged;
            BS_GDPISettings.DataSource = GDPISettings;
            Text = $"GDPI Settings {Settings.Modeset.ToString()[6..]}";
        }

        private void SetFromModeset(Modeset modeset)
        {
            GDPISettings = modeset.ToSettings();
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
            switch (Settings.Modeset)
            {
                case Modeset.Custom1:
                    Settings.CustomSettings1 = GDPISettings;
                    break;

                case Modeset.Custom2:
                    Settings.CustomSettings2 = GDPISettings;
                    break;

                case Modeset.Custom3:
                    Settings.CustomSettings3 = GDPISettings;
                    break;

                default:
                    throw new InvalidOperationException();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BS_GDPISettings_CurrentItemChanged(object sender, EventArgs e)
        {
            if (GDPISettings.Manual) { return; }
            GDPISettings.Arguments = GDPISettings.ToArguments();
        }

        private void CB_Manual_CheckedChanged(object sender, EventArgs e)
        {
            TB_Arguments.ReadOnly = !CB_Manual.Checked;
        }

        private void FormGDPISettings_Load(object sender, EventArgs e)
        {
            Icon = Owner.Icon;
        }

        private void MI_M1_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M1);
        }

        private void MI_M2_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M2);
        }

        private void MI_M3_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M3);
        }

        private void MI_M4_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M4);
        }

        private void MI_M5_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M5);
        }

        private void MI_M6_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M6);
        }

        private void MI_M7_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M7);
        }

        private void MI_M8_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M8);
        }

        private void MI_M9_Click(object sender, EventArgs e)
        {
            SetFromModeset(Modeset.M9);
        }

        #endregion UIEvents
    }
}