using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Republic_Soldier_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the files from both the Override and Optional folders to your game's override folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Optional"), modConfig.SwkotorDirectory);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Override"), modConfig.SwkotorDirectory);
        }
    }
}
