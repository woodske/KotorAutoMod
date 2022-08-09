using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ported_Alien_Voiceovers_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "Installer");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing '1. Main Mod Installation'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);

                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing '2. K1CP/Queedle Fix Compatibility Patch'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install '1. Main Mod Installation'");
                await Utils.runExecutable(TSLPatcherPath);

                Utils.tslPatcherInstructions(modConfig, mod, "Install '2. K1CP/Queedle Fix Compatibility Patch'");
                await Utils.runExecutable(TSLPatcherPath);
            }       
        }
    }
}
