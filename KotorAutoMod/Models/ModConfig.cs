using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SharpCompress;

namespace KotorAutoMod.Models
{
    internal class ModConfig
    {
        public string swkotorDirectory { get; set; } = string.Empty;

        public string compressedModsDirectory { get; set; } = string.Empty;

        public string selectedResolution { get; set; } = string.Empty;

        public string selectedAspectRatio { get; set; } = string.Empty;

        public bool firstTimeSetup { get; set; } = true;

        public ObservableCollection<Mod> selectedMods { get; set; } = new ObservableCollection<Mod>();

        public ObservableCollection<Mod> missingMods { get; set; } = new ObservableCollection<Mod>();

        public const string four_by_three = "4:3";
        public const string sixteen_by_nine = "16:9";
        public const string sixteen_by_ten = "16:10";
        public const string twentyone_by_nine = "21:9";
        public const string thirtytwo_by_nine = "32:9";

        public static string[] validAspectRatios = new[] { four_by_three, sixteen_by_nine, sixteen_by_ten, twentyone_by_nine, thirtytwo_by_nine };

        public static Dictionary<string, string[]> validScreenResolutions = new Dictionary<string, string[]> {
            // 4:3
            {  four_by_three, new [] { "800x600","960x720","1024x768","1280x960","1400x1050","1440x1080","1600x1200","1856x1392","1920x1440","2048x1536","3200x2400","4096x3072" } },

            // 16:9
            { sixteen_by_nine, new [] { "1024x576","1152x648","1280x720","1360x768","1366x768","1600x900","1920x1080","2048x1152","2560x1440","3840x2160","5120x2880","6016x3384","7680x4320","8192x4608","15360x8640" } },

            // 16:10
            { sixteen_by_ten, new [] { "1024x640","1152x720","1280x800","1440x900","1680x1050","1920x1200","2048x1280","2304x1440","2560x1600","2880x1800","3840x2400","5120x3200" } },

            // 21:9
            { twentyone_by_nine, new [] { "1280x1080","2560x1080","3440x1440","3840x1600","5120x2160","10240x4320" } },

            // 32:9
            { thirtytwo_by_nine, new [] { "1920x540","3840x1080","5120x1440","7680x2160" } }
        };
    }
}
