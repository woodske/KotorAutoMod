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
    internal class Reddit_HD_Pazaak_Cards_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all the files to your Override. Decide if you want KOTOR 2 styled green cards and move them over too.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            Utils.openUrl(mod.ModPage);
            MessageBoxResult result = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes to use KOTOR 2 styled green cards, or no to use KOTOR 1 styled.\n\n" +
                "See the mod page for examples.",
                "Pazaak color choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "__MACOSX", "green", "readme.txt" });
            if (result == MessageBoxResult.Yes)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "green"), modConfig.SwkotorDirectory, new List<string> { ".DS_Store" });
            }
        }
    }
}
