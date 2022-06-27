using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ebon_Hawk_Repairs_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Download the Animations Fix version, and move the files to your Override. These will overwrite some fixes from K1CP.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Ultimate_Ebon_Hawk_Repairs_For_K1_Animation_Fix_v1.0.2", "To Override"), modConfig.SwkotorDirectory);
        }
    }
}
