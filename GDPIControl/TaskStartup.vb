Imports TaskScheduler

Public Class TaskLaunch
	Private Const TaskName = "GDPIControl"

	Public Shared Sub Register()
		Dim taskService As ITaskService = New TaskSchedulerClass()
		taskService.Connect()

		Dim ControlTask = taskService.NewTask(0)
		ControlTask.Settings.Enabled = True
		ControlTask.Settings.Compatibility = _TASK_COMPATIBILITY.TASK_COMPATIBILITY_V2_1
		ControlTask.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST
		'Dim TC = ControlTask.Triggers
		Dim Trigger = ControlTask.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON)
		Trigger.Enabled = True

		Dim Actions = ControlTask.Actions

		Dim Action As IExecAction = CType(Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC), IExecAction)
		Action.Path = Application.ExecutablePath

		Dim rootFolder = taskService.GetFolder("\")
		rootFolder.RegisterTaskDefinition(TaskName, ControlTask, 6, Nothing, Nothing, _TASK_LOGON_TYPE.TASK_LOGON_NONE, Nothing)

		'Dim rootFolder = taskService.GetFolder("\")
		'rootFolder.GetTask(TaskName)
	End Sub

	Public Shared Sub Delete()
		Dim taskService As ITaskService = New TaskSchedulerClass()
		taskService.Connect()

		Dim rootFolder = taskService.GetFolder("\")
		'rootFolder.GetTask(TaskName)
		rootFolder.DeleteTask(TaskName, 0)
	End Sub

End Class