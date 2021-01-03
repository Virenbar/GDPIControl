Public Class GDPIProcess
	Private Shared WithEvents GDPIP As Process

	Public Shared ReadOnly Property IsRunning As Boolean
		Get
			Return GDPIP IsNot Nothing
		End Get
	End Property

	Public Shared Sub [Stop]()
		If Not IsRunning Then Exit Sub
		GDPIP.Kill()
		GDPIP = Nothing
	End Sub

	Public Shared Async Function Restart() As Task
		[Stop]()
		Await Task.Delay(5 * 1000)
		Start()
	End Function

	Public Shared Sub Start()
		If IsRunning Then Exit Sub
		Dim startInfo = New ProcessStartInfo() With {
			.FileName = Consts.GDPIPath,
			.Arguments = My.Application.Config.Arguments,
			.RedirectStandardOutput = True,
			.RedirectStandardError = True,
			.UseShellExecute = False,
			.CreateNoWindow = True}
		Dim TestInfo = New ProcessStartInfo() With {
			.FileName = "cmd.exe",
			.Arguments = $"/C start """" {Consts.GDPIPath } { My.Application.Config.Arguments}"}
		'GDPIP = Process.Start(TestInfo)
		GDPIP = Process.Start(startInfo)
		GDPIP.BeginOutputReadLine()
		GDPIP.BeginErrorReadLine()
	End Sub

	Private Shared Sub GDPIP_OutputDataReceived(sender As Object, e As DataReceivedEventArgs) Handles GDPIP.OutputDataReceived
		Console.Write(e.Data)
	End Sub

	Private Shared Sub GDPIP_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs) Handles GDPIP.ErrorDataReceived
		Console.Write(e.Data)
	End Sub

End Class