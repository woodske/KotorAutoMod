using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Light_Side_Ending_Masters_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "Ending Fix 1.1", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Fixed Version'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Fixed Version'");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
