using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Marlena_Venn_Legends_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Only install the 'INSTALL' option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Legends_Marlena_Venn_v1.1.0", "TSLPatcher"));
        }
    }
}
