using System;
using System.IO;
using System.Text;

namespace ColorfulLedKeyboardSet
{
    public class AppConfig
    {
        public int Mode { get; set; } // 0: Static, 1: Loop, 2: Breath, 3: Strobe
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Brightness { get; set; }
        public bool StartMinimized { get; set; }
        public bool AutoStart { get; set; }
        public bool Rainbow { get; set; }

        public AppConfig()
        {
            Mode = 0;
            Color = "#00FF00";
            Speed = 3;
            Brightness = 100;
            StartMinimized = false;
            AutoStart = false;
            Rainbow = false;
        }
    }

    public static class ConfigManager
    {
        private static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");

        public static AppConfig Load()
        {
            var config = new AppConfig();
            if (!File.Exists(ConfigPath)) return config;

            try
            {
                var lines = File.ReadAllLines(ConfigPath, Encoding.UTF8);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#")) continue;
                    var parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length != 2) continue;

                    var key = parts[0].Trim();
                    var val = parts[1].Trim();

                    switch (key)
                    {
                        case "Mode": config.Mode = int.Parse(val); break;
                        case "Color": config.Color = val; break;
                        case "Speed": config.Speed = int.Parse(val); break;
                        case "Brightness": config.Brightness = int.Parse(val); break;
                        case "StartMinimized": config.StartMinimized = bool.Parse(val); break;
                        case "AutoStart": config.AutoStart = bool.Parse(val); break;
                        case "Rainbow": config.Rainbow = bool.Parse(val); break;
                    }
                }
            }
            catch
            {
                // Fallback to default config on error
            }
            return config;
        }

        public static void Save(AppConfig config)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("# Colorful LED Keyboard Config");
                sb.AppendLine(string.Format("Mode={0}", config.Mode));
                sb.AppendLine(string.Format("Color={0}", config.Color));
                sb.AppendLine(string.Format("Speed={0}", config.Speed));
                sb.AppendLine(string.Format("Brightness={0}", config.Brightness));
                sb.AppendLine(string.Format("StartMinimized={0}", config.StartMinimized));
                sb.AppendLine(string.Format("AutoStart={0}", config.AutoStart));
                sb.AppendLine(string.Format("Rainbow={0}", config.Rainbow));
                File.WriteAllText(ConfigPath, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
                // Ignore save errors
            }
        }
    }
}
