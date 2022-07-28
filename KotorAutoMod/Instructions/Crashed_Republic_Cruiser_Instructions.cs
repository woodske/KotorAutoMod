using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Crashed_Republic_Cruiser_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // After installing the main mod, install the patches for HQ Blasters and Colored Loadscreens.
            string TSLPatcherPath = Path.Combine(readyMods[0], "ldr_repshipunknownworld", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the main mod.");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);

                if (Utils.isModInstalled("High Quality Blasters", modConfig))
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the HQ Blasters patch.");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
                }

                if (Utils.isModInstalled("Loadscreens in Color", modConfig))
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Colored Loadscreens patch.");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
                }
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the main mod");
                await Utils.runExecutable(TSLPatcherPath);

                if (Utils.isModInstalled("High Quality Blasters", modConfig))
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Install the HQ Blasters patch.");
                    await Utils.runExecutable(TSLPatcherPath);
                }

                if (Utils.isModInstalled("Loadscreens in Color", modConfig))
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Install the Colored Loadscreens patch.");
                    await Utils.runExecutable(TSLPatcherPath);
                }
            }
        }
    }
}
