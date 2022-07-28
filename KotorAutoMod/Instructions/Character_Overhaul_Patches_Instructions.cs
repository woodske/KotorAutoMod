using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Character_Overhaul_Patches_Instructions : IInstructions
    {
        //Download the patches for JC’s Minor Fixes, K1CP, Republic Soldier’s New Shade, and Juhani Cathar Head from miscellaneous.
        //Overwrite when prompted for each. For Republic Soldier, only install the New Shade patch.
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            // JC's
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Aesthetic Improvements"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Resolution Fixes"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Straight Fixes"), modConfig.SwkotorDirectory);

            // K1CP
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "KOTOR 1 Community Patch - Patch"), modConfig.SwkotorDirectory);

            // Republic soldier
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[2], "Republic Soldier's New Shade - Patch", "New Shade"), modConfig.SwkotorDirectory);

            // Juhani
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[3], "Miscellaneous Compatibility Patches", "Juhani Cathar Head - Patch"), modConfig.SwkotorDirectory);
        }
    }
}
