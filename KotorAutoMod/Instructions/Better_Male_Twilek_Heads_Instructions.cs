using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Better_Male_Twilek_Heads_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all the files from the textures and “Option B -Slim Necks” folders to your Override folder. These will replace textures from K1Cp.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Textures"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Option A - Slim Necks"), modConfig.SwkotorDirectory);
        }
    }
}
