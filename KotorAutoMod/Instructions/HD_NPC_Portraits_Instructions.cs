using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_NPC_Portraits_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the override folder, ignore the version 1 looks
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "hd_npc_portraits", "Override"), modConfig.SwkotorDirectory);
        }
    }
}
