using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Remove_Duplicate_Files_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the file to your swkotor folder. We’ll want to remove duplicate tpc files and not decide them one-by-one.
            modConfig.Instructions =
                "Running last script to clean up duplicate files.\n" +
                "Choose 'tpc' for the first option, and 'n' for the second option";
            string batInitialPath = Path.Combine(readyMods[0], "DelDuplicateTGA-TPC.bat");
            string batFinalPath = Path.Combine(modConfig.SwkotorDirectory, Path.GetFileName(batInitialPath));
            await Task.Run(() => File.Copy(batInitialPath, batFinalPath, true));

            await Utils.runExecutable(batFinalPath);
        }
    }
}
