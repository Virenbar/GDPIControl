namespace GDPIControl.Model
{
    public class ControlSettings
    {
        public string Arguments { get; set; }
        public GDPISettings GDPISettings { get; set; }
        public Modeset Modeset { get; set; }
        public bool LaunchMinimazed { get; set; }
        public bool AutostartGDPI { get; set; }
        public bool UseBlacklist { get; set; }
        public bool UseUserlist { get; set; }
    }
}