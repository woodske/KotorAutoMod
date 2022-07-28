using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Movie_Style_Holograms_for_Twisted_Rancor_Trio_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Movie-Style_Holograms_For_Twisted_Rancor_Trio_Puzzle", "INSTALL");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod);
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod);
                await Utils.runExecutable(TSLPatcherPath);
            }
        }
    }
}
