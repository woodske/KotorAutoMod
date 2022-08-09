using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Marlena_Venn_Legends_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Legends_Marlena_Venn_v1.1.0", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Install 'INSTALL: [K1] Marlena Venn \"Legends\" v1.1.0'");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install 'INSTALL: [K1] Marlena Venn \"Legends\" v1.1.0'");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
