using Microsoft.Win32.TaskScheduler;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace GDPIControl
{
    internal static class ControlTask
    {
        private const string TaskName = "GDPIControl";
        private static readonly string UserName = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        private static readonly string TaskPath = $@"{TaskName}\Autorun for {UserName}";

        public static bool IsRegistered => TaskService.Instance.GetTask(TaskPath) != null;

        public static void Register()
        {
            var TS = TaskService.Instance;

            var TD = TS.NewTask();
            TD.Actions.Add(Application.ExecutablePath);
            TD.Principal.RunLevel = TaskRunLevel.Highest;
            var S = TD.Settings;
            S.DisallowStartIfOnBatteries = false;
            S.ExecutionTimeLimit = TimeSpan.Zero;
            S.StopIfGoingOnBatteries = false;

            var LT = new LogonTrigger() { UserId = UserName };
            TD.Triggers.Add(LT);

            TS.RootFolder.RegisterTaskDefinition(TaskPath, TD);
        }

        public static void Delete()
        {
            if (!IsRegistered) { return; }
            TaskService.Instance.RootFolder.DeleteTask(TaskPath);
        }
    }
}