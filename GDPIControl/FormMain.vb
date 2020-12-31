Imports System.ComponentModel
Imports System.Net
Imports System.Text.RegularExpressions
Imports GDPIControl.Data

Public Class FormMain
	Private Shared ReadOnly IP_R As New Regex("((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])")
	Private BlockVisible As Boolean
	Private StrToRB As Dictionary(Of String, RadioButton)

	Public Sub New()
		' Этот вызов является обязательным для конструктора.
		InitializeComponent()
		' Добавить код инициализации после вызова InitializeComponent().
		StrToRB = New Dictionary(Of String, RadioButton) From {{"-1", RB_P1}, {"-2", RB_P2}, {"-3", RB_P3}, {"-4", RB_P4}}
		TSMI_Mini.Checked = My.Application.Config.LaunchMinimized
		TSMI_Start.Checked = My.Application.Config.StartOnLaunch

		BlockVisible = My.Application.Config.LaunchMinimized
		If My.Application.Config.StartOnLaunch Then
			StartGDPI()
		Else
			StopGDPI()
		End If
		BS_GDPISettings.DataSource = My.Application.Config.GDPIConfig
		Dim RB = If(StrToRB.ContainsKey(My.Application.Config.Arguments), StrToRB(My.Application.Config.Arguments), RB_Custom)
		RB.Checked = True
	End Sub

	Private Sub B_Copy_Click(sender As Object, e As EventArgs) Handles B_Copy.Click
		If RB_P1.Checked Then
			My.Application.Config.GDPIConfig = GDPISettings.C1
		ElseIf RB_P2.Checked Then
			My.Application.Config.GDPIConfig = GDPISettings.C2
		ElseIf RB_P3.Checked Then
			My.Application.Config.GDPIConfig = GDPISettings.C3
		ElseIf RB_P4.Checked Then
			My.Application.Config.GDPIConfig = GDPISettings.C4
		Else
			Exit Sub
		End If
		BS_GDPISettings.DataSource = My.Application.Config.GDPIConfig
		RB_Custom.Checked = True
	End Sub

	Private Sub StopGDPI()
		B_Start.Text = "Start GDPI"
		TSMI_Enable.Enabled = True
		TSMI_Disable.Enabled = False
		TrayControl.Icon = My.Resources.icon_red
		Icon = My.Resources.icon_red
		GDPIProcess.Stop()
	End Sub

	Private Sub StartGDPI()
		B_Start.Text = "Stop GDPI"
		TSMI_Enable.Enabled = False
		TSMI_Disable.Enabled = True
		TrayControl.Icon = My.Resources.icon_green
		Icon = My.Resources.icon_green
		GDPIProcess.Start()
	End Sub

	Private Sub ExitControl()
		GDPIProcess.Stop()
		TrayControl.Icon = Nothing
		TrayControl.Visible = False
		TrayControl.Dispose()
		Application.Exit()
	End Sub

	Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		e.Cancel = True
		Visible = False
	End Sub

	Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Custom.CheckedChanged, RB_P1.CheckedChanged, RB_P2.CheckedChanged, RB_P3.CheckedChanged, RB_P4.CheckedChanged
		SetArguments()
		FLP_Custom.Enabled = RB_Custom.Checked
	End Sub

	Private Sub SetArguments()
		Dim Args = ""
		If RB_Custom.Checked Then
			Args = My.Application.Config.GDPIConfig.ToString
		ElseIf RB_P1.Checked Then
			Args = "-1"
		ElseIf RB_P2.Checked Then
			Args = "-2"
		ElseIf RB_P3.Checked Then
			Args = "-3"
		ElseIf RB_P4.Checked Then
			Args = "-4"
		End If
		My.Application.Config.Arguments = Args
	End Sub

	Private Sub ShowForm()
		BlockVisible = False
		Visible = True
	End Sub

#Region "Validating"

	Private Sub DNS_IP_Validating(sender As Object, e As CancelEventArgs) Handles DNS_IP.Validating
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

#End Region

	Private Sub TrayControl_MouseClick(sender As Object, e As MouseEventArgs) Handles TrayControl.MouseClick
		If e.Button = MouseButtons.Left Then ShowForm()
	End Sub

	Private Sub TSMI_Close_Click(sender As Object, e As EventArgs) Handles TSMI_Close.Click
		ExitControl()
	End Sub

	Private Sub TSMI_Settings_Click(sender As Object, e As EventArgs) Handles TSMI_Settings.Click
		ShowForm()
	End Sub

	Private Sub TSMI_Mini_CheckedChanged(sender As Object, e As EventArgs) Handles TSMI_Mini.CheckedChanged
		My.Application.Config.LaunchMinimized = TSMI_Mini.Checked
	End Sub

	Private Sub TSMI_Start_CheckedChanged(sender As Object, e As EventArgs) Handles TSMI_Start.CheckedChanged
		My.Application.Config.StartOnLaunch = TSMI_Start.Checked
	End Sub

	Private Sub TSMI_Enable_Click(sender As Object, e As EventArgs) Handles TSMI_Enable.Click
		StartGDPI()
	End Sub

	Private Sub TSMI_Disable_Click(sender As Object, e As EventArgs) Handles TSMI_Disable.Click
		StopGDPI()
	End Sub

	Private Sub B_Stop_Click(sender As Object, e As EventArgs) Handles B_Stop.Click
		ExitControl()
	End Sub

	Private Sub B_Start_Click(sender As Object, e As EventArgs) Handles B_Start.Click
		If GDPIProcess.IsRunning Then
			StopGDPI()
		Else
			StartGDPI()
		End If
	End Sub

	Protected Overrides Sub SetVisibleCore(value As Boolean)
		If BlockVisible Then Exit Sub
		MyBase.SetVisibleCore(value)
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		MyBase.OnLoad(e)
	End Sub

	Private Sub TSMI_Blacklist_Click(sender As Object, e As EventArgs) Handles TSMI_Blacklist.Click
		Dim F = New FormBlacklist
		F.ShowDialog(Me)
	End Sub

	Private Sub TSMI_Userlist_Click(sender As Object, e As EventArgs) Handles TSMI_Userlist.Click
		Process.Start("Userlist.txt")
	End Sub

End Class