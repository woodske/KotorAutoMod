using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Selven_Legends_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Selven_'Legends'_v1.3", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Main: Selvin \"Legends\"'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);

                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Optional: Selvin's Vanilla Voices'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Main: Selvin \"Legends\"'");
                await Utils.runExecutable(TSLPatcherPath);

                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Optional: Selvin's Vanilla Voices'");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
