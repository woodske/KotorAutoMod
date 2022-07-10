using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ajunta_Palls_Swords_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Use the version not for the Weapon Model Overhaul, unless you choose to install it separately (NOT tested and NOT recommended).
            Utils.tslPatcherInstructions(modConfig, mod, "Choose the No Weapon Overhaul option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "TSLPatcher"));
        }
    }
}
