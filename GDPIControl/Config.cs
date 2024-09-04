using GDPIControl.Model;
using System;
using System.IO;
using System.Xml.Serialization;

namespace GDPIControl
{
    internal static class Config
    {
        public static ControlSettings Current { get; set; }

        private static ControlSettings Default => new()
        {
            Modeset = Modeset.M9,
            CustomSettings1 = new GDPISettings(),
            CustomSettings2 = new GDPISettings(),
            CustomSettings3 = new GDPISettings(),
            StopDriver = true
        };

        public static void Load()
        {
            if (File.Exists(Constants.ConfigPath))
            {
                try
                {
                    var XS = new XmlSerializer(typeof(ControlSettings));
                    using var SR = new StreamReader(Constants.ConfigPath);
                    Current = (ControlSettings)XS.Deserialize(SR);

                    var def = Default;
                    if (Current.Modeset == Modeset.Custom) { Current.Modeset = Modeset.Custom1; }
                    Current.CustomSettings1 ??= Current.GDPISettings ?? def.CustomSettings1;
                    Current.CustomSettings2 ??= def.CustomSettings2;
                    Current.CustomSettings3 ??= def.CustomSettings3;
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