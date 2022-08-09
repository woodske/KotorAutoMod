using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Extra_Saber_Colors_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Download the version for VPHPTC. Once you’re done installing, move the file from the alternate viridian to your Override, replacing the one already there.
            string TSLPatcherPath = Path.Combine(readyMods[0], "Extra_Colors_K1");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod);
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod);
                await Utils.runExecutable(TSLPatcherPath);
            }

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Alternate Viridian"), modConfig.SwkotorDirectory);
        }
    }
}
