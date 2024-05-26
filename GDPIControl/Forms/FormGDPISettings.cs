using GDPIControl.Model;
using System;
using System.Windows.Forms;

namespace GDPIControl.Forms
{
    public partial class FormGDPISettings : Form
    {
        //private readonly Regex IP_R = new(@"^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])$");

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