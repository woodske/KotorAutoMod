using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_JCs_Mandalorian_Armor_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install Option A, then re-run the patcher and also install the extra textures.

            string TSLPatcherPath = Path.Combine(readyMods[0], "Mandalorian_Armor_K1");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing Option A");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing Extra Textures");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install Option A");
                await Utils.runExecutable(TSLPatcherPath);
                Utils.tslPatcherInstructions(modConfig, mod, "Install Extra Textures");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
