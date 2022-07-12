using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Widescreen_Fade_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            string[] availableScreenResolutions = new string[] { "1440x900", "1530x864", "1680x1050", "1920x1080", "1920x1200", "2560x1440", "2560x1600", "3440x1440", "3840x2160" };

            if (availableScreenResolutions.Any(resolution => modConfig.SelectedResolution.Equals(resolution)))
            {
                Utils.copyFilesToOverrideInstructions(modConfig, mod);
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "KOTOR 1 Fade widescreen fix", modConfig.SelectedResolution), modConfig.SwkotorDirectory);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                    $"Your selected screen resolution of {modConfig.SelectedResolution} is not an available option for this mod. Choose Yes to install the 1920x1080 version, or no to skip this mod",
                    "Continue choice",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning
                    );
                if (result == MessageBoxResult.Yes)
                {
                    Utils.copyFilesToOverrideInstructions(modConfig, mod);
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "KOTOR 1 Fade widescreen fix", "1920x1080"), modConfig.SwkotorDirectory);
                }
            }

        }
    }
}
