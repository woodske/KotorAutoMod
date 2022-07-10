using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Sherruk_With_Lightsabers_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install the base mod first, then move the file from the patch directly to your override.
            Utils.tslPatcherInstructions(modConfig, mod);
            await Utils.runExecutable(Path.Combine(readyMods[0], "TSLPatcher"));

            // Patch
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "SAWL Patch", "Override"), modConfig.SwkotorDirectory);
        }
    }
}
