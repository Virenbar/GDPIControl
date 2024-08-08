using GDPIControl.Model;

namespace GDPIControl.Extensions
{
    public static class ModesetExtensions
    {
        public static string ToArgument(this Modeset modeset)
        {
            return modeset switch
            {
                Modeset.M1 => "-1",
                Modeset.M2 => "-2",
                Modeset.M3 => "-3",
                Modeset.M4 => "-4",
                Modeset.M5 => "-5",
                Modeset.M6 => "-6",
                Modeset.M7 => "-7",
                Modeset.M8 => "-8",
                Modeset.M9 => "-9",
                Modeset.Custom1 => GetArguments(Config.Current.CustomSettings1),
                Modeset.Custom2 => GetArguments(Config.Current.CustomSettings2),
                Modeset.Custom3 => GetArguments(Config.Current.CustomSettings3),
                _ => "-9",
            };
        }

        public static GDPISettings ToSettings(this Modeset modeset)
        {
            return modeset switch
            {
                Modeset.M1 => new GDPISettings { P = true, R = true, S = true, F = true, F_V = 2, K = true, K_V = 2, N = true, E = true, E_V = 2 },
                Modeset.M2 => new GDPISettings { P = true, R = true, S = true, F = true, F_V = 2, K = true, K_V = 2, N = true, E = true, E_V = 40 },
                Modeset.M3 => new GDPISettings { P = true, R = true, S = true, E = true, E_V = 2 },
                Modeset.M4 => new GDPISettings { P = true, R = true, S = true },
                Modeset.M5 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, ATTL = true, RFrag = true, MP = true, MP_V = 1200 },
                Modeset.M6 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, Seq = true, RFrag = true, MP = true, MP_V = 1200 },
                Modeset.M7 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, ChkSum = true, RFrag = true, MP = true, MP_V = 1200 },
                Modeset.M8 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, Seq = true, ChkSum = true, RFrag = true, MP = true, MP_V = 1200 },
                Modeset.M9 => new GDPISettings { F = true, F_V = 2, E = true, E_V = 2, Seq = true, ChkSum = true, RFrag = true, MP = true, MP_V = 1200, Q = true },
                _ => new GDPISettings(),
            };
        }

        private static string GetArguments(GDPISettings settings) => settings.Arguments ?? settings.ToArguments();
    }
}