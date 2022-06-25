using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Cantina_Song_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install version 1 if you are using the GOG or retail version, or install version 2 if you are using the Steam version.");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Song_for_the_Cantina_v1.0.3", "Install"));
        }
    }
}
