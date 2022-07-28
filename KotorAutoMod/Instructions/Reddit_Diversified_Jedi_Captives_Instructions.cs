using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Diversified_Jedi_Captives_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2", "INSTALL");
            if (modConfig.UseAuto)
            {
                // Default to base install only
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing Base option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Select the Base option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
