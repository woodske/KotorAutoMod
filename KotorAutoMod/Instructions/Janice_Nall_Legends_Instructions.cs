using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Janice_Nall_Legends_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Select and install the main mod only");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Legends_Janice_Nall_and_the_Incomplete_Droids_v1.1.1", "TSLPatcher"));
        }
    }
}
