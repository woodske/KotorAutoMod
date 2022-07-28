using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Missing_Lamps_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the patcher twice, first to install the lamp fix and then once to install the optional pillar facing fix.
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_UWTMF_Missing_Lamps_Fix_v1.0.0", "Install");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the main option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the optional option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the main option");
                await Utils.runExecutable(TSLPatcherPath);
                Utils.tslPatcherInstructions(modConfig, mod, "Install the optional option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
