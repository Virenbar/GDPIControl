using System;
using System.IO;
using System.Windows.Forms;

namespace GDPIControl
{
    internal static class Constants
    {
        public const string BlacklistName = "Blacklist.txt";
        public const string UserlistName = "Userlist.txt";
        private const string ConfigName = "Config.xml";
        private const string NBLName = "Blacklist.temp.txt";
        private const string x86 = @"GDPI\x86\goodbyedpi.exe";
        private const string x86_64 = @"GDPI\x86_64\goodbyedpi.exe";
        public static string BlacklistPath => Path.Combine(Application.StartupPath, BlacklistName);
        public static string BlacklistTempPath => Path.Combine(Application.StartupPath, NBLName);
        public static string BlacklistURI { get; } = "https://antizapret.prostovpn.org/domains-export.txt";
        public static string ConfigPath => Path.Combine(Application.StartupPath, ConfigName);
        public static string GDPIPath => Path.Combine(Application.StartupPath, Environment.Is64BitOperatingSystem ? x86_64 : x86);
        public static string UserlistPath => Path.Combine(Application.StartupPath, UserlistName);
    }
}