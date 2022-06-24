using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Light_Side_Ending_Masters_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the fixed version");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Ending Fix 1.1", "TSLPatcher"));
        }
    }
}
