Imports System.IO
Imports System.Xml.Serialization
Imports GDPIControl.Data
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' Для MyApplication имеются следующие события:
	' Startup: возникает при запуске приложения перед созданием начальной формы.
	' Shutdown: возникает после закрытия всех форм приложения.  Это событие не создается, если происходит аварийное завершение работы приложения.
	' UnhandledException: возникает, если в приложении обнаруживается необработанное исключение.
	' StartupNextInstance: возникает при запуске приложения, допускающего одновременное выполнение только одного экземпляра, если это приложение уже активно.
	' NetworkAvailabilityChanged: возникает при изменении состояния подключения — при подключении или отключении.
	Partial Friend Class MyApplication
		Public Config As ControlSettings

		Private Sub LoadConfig()
			If File.Exists(Consts.ConfigPath) Then
				Dim xs As New XmlSerializer(GetType(ControlSettings))
				Using SR As New StreamReader(Consts.ConfigPath)
					Config = DirectCast(xs.Deserialize(SR), ControlSettings)
				End Using
			Else
				Config = New ControlSettings With {.GDPIConfig = GDPISettings.C4, .Arguments = "-4"}
			End If
		End Sub

		Private Sub SaveConfig()
			Dim xs As New XmlSerializer(GetType(ControlSettings))
			Using SW As New StreamWriter(Consts.ConfigPath)
				xs.Serialize(SW, Config)
			End Using
		End Sub

		Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
			SaveConfig()
		End Sub

		Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
			LoadConfig()
		End Sub

	End Class
End Namespace