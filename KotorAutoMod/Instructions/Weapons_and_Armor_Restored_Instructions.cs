using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Weapons_and_Armor_Restored_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the 'plus' option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the 'plus' option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
