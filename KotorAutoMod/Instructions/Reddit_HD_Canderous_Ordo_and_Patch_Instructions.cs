using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_HD_Canderous_Ordo_and_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Delete P_CandH01.tga, P_CandH01.txi, and PO_pcanderous.tga before moving the remaining files from the first installation to your override.
            // Next install the Patch, which will overwrite one file.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "P_CandH01.tga", "P_CandH01.txi", "PO_pcanderous.tga" });

            // patch
            await Utils.moveAllToOverrideDirectory(readyMods[1], modConfig.SwkotorDirectory);
        }
    }
}
