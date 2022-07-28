using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Thigh_High_Boots_For_Twilek_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "[K1]_Thigh-High_Boots_For_Twilek_Body_MODDERS_RESOURCE", "NPC Replacement"), modConfig.SwkotorDirectory, new List<string> { "OPTIONAL" });
        }
    }
}
