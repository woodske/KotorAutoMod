using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Dodonnas_Transmission_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer, revisted option is recommended
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Dodonna's_Transmission_v1.1", "Transmission");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Revisted option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the Revisted option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
