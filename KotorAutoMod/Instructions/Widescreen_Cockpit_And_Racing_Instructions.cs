﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Widescreen_Cockpit_And_Racing_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the Override folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory);
        }
    }
}
