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
    internal class HD_Darth_Malak_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //  Decide whether or not you want the blue or red eyes version, and move the files to your Override (including N_DarthMalak01.tga).
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            Utils.openUrl(mod.ModPage[0]);
            MessageBoxResult result = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes for red eyes or no for blue eyes\n\n" +
                "See the mod page for examples.",
                "Overlay choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            if (result == MessageBoxResult.Yes)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Malak (Red Eyes)"), modConfig.SwkotorDirectory);
            }
            else
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Malak (Blue Eyes)"), modConfig.SwkotorDirectory);
            }

            await Task.Run(() => File.Copy(readyMods[1], Path.Combine(modConfig.SwkotorDirectory, "Override", Path.GetFileName(readyMods[1])), true));
        }
    }
}
