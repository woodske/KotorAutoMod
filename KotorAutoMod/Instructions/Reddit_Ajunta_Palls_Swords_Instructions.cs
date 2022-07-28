using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ajunta_Palls_Swords_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Use the version not for the Weapon Model Overhaul, unless you choose to install it separately (NOT tested and NOT recommended).

            string TSLPatcherPath = Path.Combine(readyMods[0], "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the No Weapon Overhaul option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the No Weapon Overhaul option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
