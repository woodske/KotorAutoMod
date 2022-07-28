using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Taris_and_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Ultimate Taris High Resolution - TPC Version", "Taris HR TPC Ver", "Override"), modConfig.SwkotorDirectory);

            // patch
            await Utils.moveAllToOverrideDirectory(readyMods[1], modConfig.SwkotorDirectory);
        }
    }
}
