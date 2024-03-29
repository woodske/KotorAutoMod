﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class New_Grass_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override. Ignore the disable speed blur folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "(disable Speed Blur)" });
        }
    }
}
