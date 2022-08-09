using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Reflective_Lightsaber_Blades_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install only the Standard option.
            string TSLPatcherPath = Path.Combine(readyMods[0], "New_Lightsaber_Blades_K1_v_1", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Modify Standard Lightsaber (Vanilla sabers) option");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install only the 'Modify Standard Lightsaber (Vanilla sabers)' option");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
