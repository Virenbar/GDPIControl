Imports System.Runtime.InteropServices

Public Class Consts

	'Private Const GDPIName = "GoodbyeDPI"
	'Private Const WDName = "WinDivert1.4"

	Public Const BlacklistURI = "https://antizapret.prostovpn.org/domains-export.txt"
	Private Const x86 = "GDPI\x86\goodbyedpi.exe"
	Private Const x86_64 = "GDPI\x86_64\goodbyedpi.exe"
	Private Const ConfigName = "Config.xml"
	Private Const UName = "Userlist.txt"
	Private Const BLName = "Blacklist.txt"
	Private Const NBLName = "NewBlacklist.txt"

	Public Shared ReadOnly Property GDPIPath As String
		Get
			Dim path = If(Environment.Is64BitOperatingSystem, x86_64, x86)
			Return IO.Path.Combine(Application.StartupPath, path)
		End Get
	End Property

	Public Shared ReadOnly Property ConfigPath As String
		Get
			Return IO.Path.Combine(Application.StartupPath, ConfigName)
		End Get
	End Property

	Public Shared ReadOnly Property UserlistPath As String
		Get
			Return IO.Path.Combine(Application.StartupPath, UName)
		End Get
	End Property

	Public Shared ReadOnly Property BlacklistPath As String
		Get
			Return IO.Path.Combine(Application.StartupPath, BLName)
		End Get
	End Property

	Public Shared ReadOnly Property NewBlacklistPath As String
		Get
			Return IO.Path.Combine(Application.StartupPath, NBLName)
		End Get
	End Property

End Class