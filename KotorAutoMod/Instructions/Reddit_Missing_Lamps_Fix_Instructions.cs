using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Missing_Lamps_Fix_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the patcher twice, first to install the lamp fix and then once to install the optional pillar facing fix.
            Utils.tslPatcherInstructions(modConfig, mod, "Install the main option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_UWTMF_Missing_Lamps_Fix_v1.0.0", "Install"));
            Utils.tslPatcherInstructions(modConfig, mod, "Install the optional option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_UWTMF_Missing_Lamps_Fix_v1.0.0", "Install"));
        }
    }
}
