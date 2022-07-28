using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Galaxy_Map_Fix_Pack_Instructions : IInstructions
    {
        private static Dictionary<string, string[]> unsupportedScreenResolutions = new Dictionary<string, string[]> {
            // 4:3
            {  ModConfig.four_by_three, new [] { "3200x2400","4096x3072" } },

            // 16:9
            { ModConfig.sixteen_by_nine, new [] { "6016x3384","8192x4608","15360x8640" } },

            // 16:10
            { ModConfig.sixteen_by_ten, new [] { "1024x640","1152x720","2048x1280","2304x1440","2880x1800","3840x2400","5120x3200" } },

            // 21:9
            { ModConfig.twentyone_by_nine, new [] { "3840x1600","10240x4320" } },
        };
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer for Galaxy Map Fix Pack and move to override for HR Menu Patch
            Utils.tslPatcherInstructions(modConfig, mod, "Install the vanilla version");

            string mapFixModFile = readyMods.First(readyMod => readyMod.Contains("K1 Galaxy Map Fix Pack"));
            string hrMenuPatchModFile = readyMods.First(readyMod => readyMod.Contains("HR Menu Patch"));

            await Utils.runExecutable(Path.Combine(mapFixModFile, "TSLPatcher"));

            // Check that the HR Menu Patch supports the ratio/resolution
            if (modConfig.SelectedAspectRatio == ModConfig.thirtytwo_by_nine)
            {
                MessageBox.Show("The HR Menu Patch portion of this mod does not support 32:9 aspect ratios, skipping this part",
                    "Unsupported aspect ratio",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                return;
            }

            string[] unsupportedScreenResolutionsForAspectRatio = unsupportedScreenResolutions[modConfig.SelectedAspectRatio];
            if (unsupportedScreenResolutionsForAspectRatio.Any(screenResolution => screenResolution.Equals(modConfig.SelectedResolution)))
            {
                MessageBox.Show($"The HR Menu Patch portion of this mod does not support {modConfig.SelectedResolution} screen resolution, skipping this part",
                    "Unsupported screen resolution",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                return;
            }

            string aspectRatioFolder = modConfig.SelectedAspectRatio.Replace(":", "-by-");
            string resolutionFolder = "gui." + modConfig.SelectedResolution;

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(hrMenuPatchModFile, aspectRatioFolder, resolutionFolder), modConfig.SwkotorDirectory);
        }
    }
}
