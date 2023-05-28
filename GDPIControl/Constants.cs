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

        /// <summary>
        /// .NET 6 uses TEMP directory for GDPI
        /// </summary>
        public static string GDPIPath => Path.Combine(Application.StartupPath, Environment.Is64BitOperatingSystem ? x86_64 : x86);

#if NET6_0_OR_GREATER
        public static string StartupPath => Path.GetDirectoryName(Environment.ProcessPath);
#else
        public static string StartupPath => Application.StartupPath;
#endif
        public static string UserlistPath => Path.Combine(StartupPath, UserlistName);
    }
}