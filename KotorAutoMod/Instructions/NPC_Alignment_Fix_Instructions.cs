using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class NPC_Alignment_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "TSLPatcher");
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
        }
    }
}
