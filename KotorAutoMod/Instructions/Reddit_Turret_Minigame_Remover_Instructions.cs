﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Turret_Minigame_Remover_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory);
        }
    }
}
