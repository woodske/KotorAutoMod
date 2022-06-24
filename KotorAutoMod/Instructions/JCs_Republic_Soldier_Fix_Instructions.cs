using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Republic_Soldier_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move mdl/mdx files from optional and default to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Optional"), modConfig.SwkotorDirectory, new List<string> { "PFBBL01.tga", "PMBBL01.tga" });
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Override"), modConfig.SwkotorDirectory, new List<string> { "N_RepSold_F01.tga" });
        }
    }
}
