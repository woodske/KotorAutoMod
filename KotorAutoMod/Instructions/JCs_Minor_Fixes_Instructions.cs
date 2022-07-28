using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Minor_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the Override folder from Resolution Fixes, Straight Fixes, and Aesthetic Improvements
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            string[] subFolders = new string[] { "Resolution Fixes", "Straight Fixes", "Aesthetic Improvements" };

            foreach (string subFolder in subFolders)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], subFolder), modConfig.SwkotorDirectory);
            }
        }
    }
}
