using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Diversified_Jedi_Captives_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer for the main mod and captive on Dantooine. Move the compatibility patch files to override.
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2", "INSTALL");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Base Installation'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);

                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing 'Optional: Jedi Captives Appear on Dantooine'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 1);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Base Installation'");
                await Utils.runExecutable(TSLPatcherPath);

                Utils.tslPatcherInstructions(modConfig, mod, "Install 'Optional: Jedi Captives Appear on Dantooine'");
                await Utils.runExecutable(TSLPatcherPath);
            }
            

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "[K1]_Diversified_Jedi_Captives_on_the_SF_JC_TSL_Robes_Compatibility_Patch", "FOR OVERRIDE"), modConfig.SwkotorDirectory);
        }
    }
}
