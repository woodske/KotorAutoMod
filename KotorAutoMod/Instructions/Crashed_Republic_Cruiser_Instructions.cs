using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Crashed_Republic_Cruiser_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // After installing the main mod, install the patches for HQ Blasters and Colored Loadscreens.
            Utils.tslPatcherInstructions(modConfig, mod, "Install the main mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "ldr_repshipunknownworld", "TSLPatcher"));
            Utils.tslPatcherInstructions(modConfig, mod, "Install the HQ Blasters patch");
            await Utils.runExecutable(Path.Combine(readyMods[0], "ldr_repshipunknownworld", "TSLPatcher"));
            Utils.tslPatcherInstructions(modConfig, mod, "Install the Colored Loadscreens patch");
            await Utils.runExecutable(Path.Combine(readyMods[0], "ldr_repshipunknownworld", "TSLPatcher"));
        }
    }
}
