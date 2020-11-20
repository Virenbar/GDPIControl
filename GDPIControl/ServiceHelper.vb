Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.Threading

Public Class ServiceHelper

	Private GDPIService As ServiceController
	Private WDService As ServiceController

	Public Sub Init()

		Dim scServices = ServiceController.GetServices()
	End Sub

	Public Shared Function IsServiceRunning() As Boolean

	End Function

End Class