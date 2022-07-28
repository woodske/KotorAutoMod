using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Character_Startup_Changes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer then move files to override from the patch
            string TSLPatcherPath = Path.Combine(readyMods[0], "Character Start Up Changes", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod);
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod);
                await Utils.runExecutable(TSLPatcherPath);
            }

            // Patch
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "Character_Startup_Changes_Patch", "Override"), modConfig.SwkotorDirectory);
        }
    }
}
