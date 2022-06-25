using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Robe_Adjustment_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install 'Early Jedi Robes'");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Robe_Adjustment_K1"));
        }
    }
}
