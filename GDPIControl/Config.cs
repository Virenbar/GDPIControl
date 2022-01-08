using GDPIControl.Model;
using System.IO;
using System.Xml.Serialization;

namespace GDPIControl
{
    internal static class Config
    {
        public static ControlSettings Current { get; set; }

        public static void Load()
        {
            if (File.Exists(Constants.ConfigPath))
            {
                var XS = new XmlSerializer(typeof(ControlSettings));
                using var SR = new StreamReader(Constants.ConfigPath);
                Current = (ControlSettings)XS.Deserialize(SR);
            }
            else
            {
                Current = new ControlSettings() { Modeset = Modeset.M5, GDPISettings = GDPISettings.ModesetSettings(Modeset.M5) };
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