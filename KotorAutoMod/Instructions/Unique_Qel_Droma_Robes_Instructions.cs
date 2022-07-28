﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Unique_Qel_Droma_Robes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Effixian's Qel-Droma Robes Reskin for JC's Cloaked Jedi Robes", "Effixian's Qel-Droma Robes Reskin for JC's Cloaked Jedi Robes"), modConfig.SwkotorDirectory);
        }
    }
}
