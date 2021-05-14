'Imports TaskScheduler
Imports Microsoft.Win32.TaskScheduler
Imports System.Security.Principal

Public Class TaskLaunch
	Private Const TaskName = "GDPIControl"
	Private Shared ReadOnly UserName As String = WindowsIdentity.GetCurrent().Name.Split("\"c)(1)
	Private Shared ReadOnly TaskPath As String = $"GDPIControl\Autorun for {UserName}"

	Public Shared Sub Register()
		Dim TS = TaskService.Instance

		Dim TD = TS.NewTask()
		TD.Actions.Add(Application.ExecutablePath)
		TD.Principal.RunLevel = TaskRunLevel.Highest
		With TD.Settings
			.DisallowStartIfOnBatteries = False
			.ExecutionTimeLimit = TimeSpan.Zero
			.StopIfGoingOnBatteries = False
		End With

		Dim LT = New LogonTrigger With {.UserId = UserName}
		TD.Triggers.Add(LT)

		TS.RootFolder.RegisterTaskDefinition(TaskPath, TD)
	End Sub

	Public Shared Sub Delete()
		Dim TS = TaskService.Instance
		Dim T = TS.GetTask(TaskPath)
		If T Is Nothing Then Exit Sub
		TS.RootFolder.DeleteTask(TaskPath)
	End Sub

	'Public Shared Sub _Register()
	'	Dim taskService As ITaskService = New TaskSchedulerClass()
	'	taskService.Connect()

	'	Dim ControlTask = taskService.NewTask(0)
	'	ControlTask.Settings.Enabled = True
	'	ControlTask.Settings.Compatibility = _TASK_COMPATIBILITY.TASK_COMPATIBILITY_V2_1
	'	ControlTask.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST
	'	'Dim TC = ControlTask.Triggers
	'	Dim Trigger = ControlTask.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON)
	'	Trigger.Enabled = True

	'	Dim Actions = ControlTask.Actions

	'	Dim Action As IExecAction = CType(Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC), IExecAction)
	'	Action.Path = Application.ExecutablePath

	'	Dim rootFolder = taskService.GetFolder("\")
	'	rootFolder.RegisterTaskDefinition(TaskName, ControlTask, 6, Nothing, Nothing, _TASK_LOGON_TYPE.TASK_LOGON_NONE, Nothing)

	'	'Dim rootFolder = taskService.GetFolder("\")
	'	'rootFolder.GetTask(TaskName)
	'End Sub

	'Public Shared Sub _Delete()
	'	Dim taskService As ITaskService = New TaskSchedulerClass()
	'	taskService.Connect()

	'	Dim rootFolder = taskService.GetFolder("\")
	'	'rootFolder.GetTask(TaskName)
	'	rootFolder.DeleteTask(TaskName, 0)
	'End Sub

End Class