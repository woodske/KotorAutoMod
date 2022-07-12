using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Realistic_Visual_Effects_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the Sith Specter/Rece compatibility option if using the Ajunta Pall's Swords mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Real Visual Effects K1"));
        }
    }
}
