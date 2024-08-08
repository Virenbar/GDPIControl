using System;
using System.IO;
using System.Windows.Forms;

namespace GDPIControl
{
    internal static class Constants
    {
        private const string BlacklistName = "Blacklist.txt";
        private const string BlacklistTempName = "Blacklist.temp.txt";
        private const string ConfigName = "Config.xml";
        private const string UserlistName = "Userlist.txt";
        private const string x86 = @"GDPI\x86\goodbyedpi.exe";
        private const string x86_64 = @"GDPI\x86_64\goodbyedpi.exe";
        public static string BlacklistPath => Path.Combine(StartupPath, BlacklistName);
        public static string BlacklistTempPath => Path.Combine(StartupPath, BlacklistTempName);
        public static string ConfigPath => Path.Combine(StartupPath, ConfigName);
        public static string GDPIPath => Path.Combine(StartupPath, Environment.Is64BitOperatingSystem ? x86_64 : x86);
        public static string UserlistPath => Path.Combine(StartupPath, UserlistName);

        #region StartupPath
        /*
        .NET 6 uses TEMP directory for GDPIControl
        Application.StartupPath - Real executable path
        Environment.ProcessPath - Packed executable path
        */

#if NET6_0_OR_GREATER
        public static string StartupPath => Path.GetDirectoryName(Environment.ProcessPath);
#else
        public static string StartupPath => Application.StartupPath;
#endif
        #endregion StartupPath
    }
}