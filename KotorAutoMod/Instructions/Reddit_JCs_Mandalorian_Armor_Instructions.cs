using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_JCs_Mandalorian_Armor_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install Option A, then re-run the patcher and also install the extra textures.
            Utils.tslPatcherInstructions(modConfig, mod, "Install Option A");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Mandalorian_Armor_K1"));
            Utils.tslPatcherInstructions(modConfig, mod, "Install Extra Textures");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Mandalorian_Armor_K1"));
        }
    }
}
