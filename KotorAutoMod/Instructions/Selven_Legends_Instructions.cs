using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Selven_Legends_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Select and install the main mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Selven_'Legends'_v1.3", "TSLPatcher"));

            Utils.tslPatcherInstructions(modConfig, mod, "Select and install vanilla voices only");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Selven_'Legends'_v1.3", "TSLPatcher"));
        }
    }
}
