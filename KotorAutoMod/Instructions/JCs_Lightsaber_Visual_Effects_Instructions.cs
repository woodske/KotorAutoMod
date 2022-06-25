using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Lightsaber_Visual_Effects_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all of the files to your Override, then move the files from “Brighter Green” and “Darker Blue” from the Alternate Textures folder to your Override (replacing the ones there).
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Override"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Alternate Textures", "Brighter Green"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Alternate Textures", "Darker Blue"), modConfig.SwkotorDirectory);
        }
    }
}
