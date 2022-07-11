using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ajunta_Palls_Blade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install the Sith Specter/Rece compatibility option if using Ajunta Pall's Swords.
            Utils.tslPatcherInstructions(modConfig, mod, "Install the Sith Specter/Rece compatibility option if using the Ajunta Pall's Swords mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b", "TSLPatcher"));
        }
    }
}
