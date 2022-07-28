using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Vision_Enhancement_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "Vision_Enhancement_K1");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the default version");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install the default version");
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
