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
    internal class Reddit_Ajunta_Pall_Appearance_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //  Decide whether or not you want the Transparent/Non-Transparent and Sith eyes or not, then move the appropriate files to override. Then run the patcher.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            Utils.openUrl(mod.ModPage[0]);
            MessageBoxResult transparencyResult = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes to make Ajunta Pall transparent, or no to make him opaque.\n\n" +
                "See the mod page for examples.",
                "Transparency choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            MessageBoxResult eyesResult = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes to use Sith eyes, or no to use ghost eyes.\n\n" +
                "See the mod page for examples.",
                "Eyes choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            if (transparencyResult == MessageBoxResult.Yes)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Transparent Skins"), modConfig.SwkotorDirectory, new List<string> { "Sith Eyes" });
                if (eyesResult == MessageBoxResult.Yes)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Transparent Skins", "Sith Eyes"), modConfig.SwkotorDirectory);
                }
            }
            else
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Non-Transparent Skins"), modConfig.SwkotorDirectory, new List<string> { "Sith Eyes" });
                if (eyesResult == MessageBoxResult.Yes)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Non-Transparent Skins", "Sith Eyes"), modConfig.SwkotorDirectory);
                }
            }

            // Patch
            Utils.tslPatcherInstructions(modConfig, mod);
            await Utils.runExecutable(Path.Combine(readyMods[1], "TSLPatcher"));
        }
    }
}
