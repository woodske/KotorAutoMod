using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Bastilas_Dark_Bodysuit_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Use the regular install--other install variants have been linked to sequence breaks, but the normal install variant is fully functional.
            string TSLPatcherPath = Path.Combine(readyMods[0], "Install");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Regular Install");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the Regular Install option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
