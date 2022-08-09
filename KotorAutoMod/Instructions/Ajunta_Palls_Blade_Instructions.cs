using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ajunta_Palls_Blade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'COMPATIBILITY INSTALL: VarsityPuppet's & Rece's'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'COMPATIBILITY INSTALL: VarsityPuppet's & Rece's'");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
