Imports System.Net
Imports System.IO

Public Class FormBlacklist
	Private WithEvents Client As New WebClient()

	Private Async Sub FormBlacklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			If File.Exists(Consts.NewBlacklistPath) Then File.Delete(Consts.NewBlacklistPath)
			Await Client.DownloadFileTaskAsync(New Uri(Consts.BlacklistURI), Consts.NewBlacklistPath)
			If File.Exists(Consts.BlacklistPath) Then File.Delete(Consts.BlacklistPath)
			File.Move(Consts.NewBlacklistPath, Consts.BlacklistPath)
			MessageBox.Show("Blacklist download done")
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub Client_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Client.DownloadProgressChanged
		PB.Value = e.ProgressPercentage
		L_Size.Text = $"{Math.Round(e.TotalBytesToReceive / 1024, 2)} КВ"
		L_Done.Text = $"{Math.Round(e.BytesReceived / 1024, 2)} КВ"
	End Sub

	Private Sub FormBlacklist_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

	End Sub

End Class