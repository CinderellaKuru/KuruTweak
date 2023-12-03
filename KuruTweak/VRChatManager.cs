using Newtonsoft.Json;
using System;
using System.IO;

namespace KuruTweak
{
    public class VRChatManager
    {
        private static readonly string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static readonly string VRChatPath = Path.Combine(LocalAppData + "Low", "VRChat", "vrchat");
        private static readonly string ConfigPath = Path.Combine(VRChatPath, "config.json");

        public VRChatConfiguration Configuration = new VRChatConfiguration();

        public VRChatManager() { }

        public string GetConfigPath() => ConfigPath;

        public bool ConfigFileExists() => File.Exists(ConfigPath);

        public void LoadConfigFromFile(string path)
        {
            try
            {
                var jsonConfig = File.ReadAllText(path);
                var loadedConfig = JsonConvert.DeserializeObject<VRChatConfiguration>(jsonConfig);

                Configuration.DisableRichPresence = loadedConfig.DisableRichPresence;
                Configuration.CacheDirectory = loadedConfig.CacheDirectory;
                Configuration.CacheSize = loadedConfig.CacheSize;
                Configuration.CacheExpiryDelay = loadedConfig.CacheExpiryDelay;
                Configuration.CameraResolutionHeight = loadedConfig.CameraResolutionHeight;
                Configuration.CameraResolutionWidth = loadedConfig.CameraResolutionWidth;
                Configuration.ScreenshotResolutionHeight = loadedConfig.ScreenshotResolutionHeight;
                Configuration.ScreenshotResolutionWidth = loadedConfig.ScreenshotResolutionWidth;
                Configuration.PictureOutputFolder = loadedConfig.PictureOutputFolder;
                Configuration.PictureOutputSplitByDate = loadedConfig.PictureOutputSplitByDate;
                Configuration.FPVSteadyCamFOV = loadedConfig.FPVSteadyCamFOV;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading config file: {ex.Message}");
            }
        }

        public void SaveConfigToFile()
        {
            try
            {
                var jsonConfig = JsonConvert.SerializeObject(Configuration, Formatting.Indented);
                File.WriteAllText(ConfigPath, jsonConfig);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving config file: {ex.Message}");
            }
        }
    }
}
