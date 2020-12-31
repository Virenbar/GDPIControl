Imports System.Net

Public Class FormBlacklist
	Private WithEvents Client As New WebClient()

	Private Sub FormBlacklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Client.DownloadFileAsync(New Uri("https://antizapret.prostovpn.org/domains-export.txt"), "NewBlacklist.txt")
	End Sub

	Private Sub Client_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Client.DownloadProgressChanged
		PB.Value = e.ProgressPercentage
		L_Size.Text = e.TotalBytesToReceive.ToString
		L_Done.Text = e.BytesReceived.ToString
	End Sub

	Private Sub Client_DownloadDataCompleted(sender As Object, e As DownloadDataCompletedEventArgs) Handles Client.DownloadDataCompleted
		'IO.File.Move("NewBlacklist.txt", "Blacklist.txt")
		MessageBox.Show("Done")
	End Sub

	Private Sub FormBlacklist_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

	End Sub

End Class