﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class GenoHaradan_Light_Side_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod);
            await Utils.runExecutable(Path.Combine(readyMods[0], "Genoharadan - Light Side", "TSLPatcher"));
        }
    }
}
