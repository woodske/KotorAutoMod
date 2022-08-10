using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ajunta_Pall_Unique_Appearance_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "Spectral_Ajunta_Pall_Canon_Appearance", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Install Spectral Ajunta Pall Canonical Appearance'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Install Spectral Ajunta Pall Canonical Appearance'");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
