using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Better_Twilek_Heads_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //  Decide whether or not you want the slim or original then move the appropriate files to override. After, move all files from textures to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            // Utils.openUrl(mod.ModPage[0]);

            if (modConfig.UseAuto)
            {
                // default to slim necks
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Option A - Slim Necks"), modConfig.SwkotorDirectory);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                    $"Options for {mod.ListName}:\n" +
                    "Choose yes to use slim necks, or no to use original necks.\n\n" +
                    "See the mod page for examples.",
                    "Neck choice",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                );
                if (result == MessageBoxResult.Yes)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Option A - Slim Necks"), modConfig.SwkotorDirectory);
                }
                else
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Option B - Original Necks"), modConfig.SwkotorDirectory);
                }
            }

            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Textures"), modConfig.SwkotorDirectory);
        }
    }
}
