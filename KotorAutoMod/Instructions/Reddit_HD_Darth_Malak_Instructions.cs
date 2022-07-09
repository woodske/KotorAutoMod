using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_HD_Darth_Malak_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the main file in the directory to your override folder, then the files from the "Malak (Blue Eyes)" folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "Malak (Blue Eyes)", "Malak (Red Eyes)" });
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Malak (Blue Eyes)"), modConfig.SwkotorDirectory);
        }
    }
}
