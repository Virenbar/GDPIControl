Public Class ProcessHelper
	Private Shared GDPIProcess As Process

	Public Shared Sub Init()
		GDPIProcess.Start()
		Dim d = New ProcessStartInfo()
	End Sub

	Public Shared Sub Start()
		GDPIProcess = Process.Start(Consts.PathToEXE, "")
	End Sub

	Public Shared Sub [Stop]()
		GDPIProcess.Kill()
		GDPIProcess = Nothing
	End Sub

	Public Shared Async Function Restart() As Task
		[Stop]()
		Await Task.Delay(5 * 1000)
		Start()
	End Function

	Public Shared ReadOnly Property IsRunning As Boolean
		Get
			Return GDPIProcess IsNot Nothing
		End Get
	End Property

End Class