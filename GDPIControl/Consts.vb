Imports System.Runtime.InteropServices

Public Class Consts
	Public Const x86 = "GDPI\x86\goodbyedpi.exe"
	Public Const x86_64 = "GDPI\x86_64\goodbyedpi.exe"
	Public Const GDPIName = "GoodbyeDPI"
	Public Const WDName = "WinDivert1.4"
	Public Const ConfigFile = "Config.xml"

	Public Shared ReadOnly Property PathToEXE As String
		Get
			Return If(RuntimeInformation.OSArchitecture = Architecture.X86, x86, x86_64)
		End Get
	End Property

End Class