namespace GDPIControl.Model
{
    public class ControlSettings
    {
        public string Arguments { get; set; }
        public bool AutostartGDPI { get; set; }
        public GDPISettings CustomSettings1 { get; set; }
        public GDPISettings CustomSettings2 { get; set; }
        public GDPISettings CustomSettings3 { get; set; }
        public GDPISettings GDPISettings { get; set; }
        public bool LaunchMinimazed { get; set; }
        public Modeset Modeset { get; set; }
        public bool StopDriver { get; set; }
        public bool UseBlacklist { get; set; }
        public bool UseUserlist { get; set; }
    }
}