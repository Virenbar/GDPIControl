using GDPIControl.Model;
using System;
using System.IO;
using System.Xml.Serialization;

namespace GDPIControl
{
    internal static class Config
    {
        public static ControlSettings Current { get; set; }

        private static ControlSettings Default => new() { Modeset = Modeset.M5, GDPISettings = GDPISettings.ModesetSettings(Modeset.M5) };

        public static void Load()
        {
            if (File.Exists(Constants.ConfigPath))
            {
                try
                {
                    var XS = new XmlSerializer(typeof(ControlSettings));
                    using var SR = new StreamReader(Constants.ConfigPath);
                    Current = (ControlSettings)XS.Deserialize(SR);
                }
                catch (Exception)
                {
                    Current = Default;
                }
            }
            else
            {
                Current = Default;
            }
        }

        public static void Save()
        {
            var XS = new XmlSerializer(typeof(ControlSettings));
            using var SW = new StreamWriter(Constants.ConfigPath);
            XS.Serialize(SW, Current);
        }
    }
}