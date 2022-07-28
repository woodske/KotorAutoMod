using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ajunta_Palls_Blade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the compatibility version for Rece’s and VarsityPuppet’s.");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b", "TSLPatcher"));
        }
    }
}
