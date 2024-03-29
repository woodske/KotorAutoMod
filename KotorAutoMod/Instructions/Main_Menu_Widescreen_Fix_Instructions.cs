﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Main_Menu_Widescreen_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all from For Override to the Override folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "[K1]_Main_Menu_Widescreen_Fix_v1.2", "For Override"), modConfig.SwkotorDirectory);
        }
    }
}
