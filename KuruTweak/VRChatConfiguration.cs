using System;
using System.IO;

namespace KuruTweak
{
    public class VRChatConfiguration
    {
        public bool DisableRichPresence { get; set; } = false;
        public string CacheDirectory { get; set; } = Path.Combine(VRChatManager.VRChatPath, "Cache-WindowsPlayer");
        public int CacheSize { get; set; } = 20;
        public int CacheExpiryDelay { get; set; } = 30;
        public int CameraResolutionHeight { get; set; } = 1080;
        public int CameraResolutionWidth { get; set; } = 1920;
        public int ScreenshotResolutionHeight { get; set; } = 1080;
        public int ScreenshotResolutionWidth { get; set; } = 1920;
        public string PictureOutputFolder { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "VRChat");
        public bool PictureOutputSplitByDate { get; set; } = true;
        public int FPVSteadyCamFOV { get; set; } = 50;
    }
}
