using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Vanilla_Masks_Overhaul_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "KoToR Vanilla Masks Overhaul"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "icons"), modConfig.SwkotorDirectory);
        }
    }
}
