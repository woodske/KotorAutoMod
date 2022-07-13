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
    internal class Animated_Ebon_Hawk_Monitors_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //  Decide whether or not you want with or without glass version, and move the files to your Override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            Utils.openUrl(mod.ModPage[0]);
            MessageBoxResult result = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes for with glass overlays or no for without glass overlays.\n\n" +
                "See the mod page for examples.",
                "Overlay choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );

            if (result == MessageBoxResult.Yes)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "With Glass Overlays"), modConfig.SwkotorDirectory);
            }
            else
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Without Glass Overlays"), modConfig.SwkotorDirectory);
            }
        }
    }
}
