using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Bastilas_Dark_Bodysuit_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Use the regular install--other install variants have been linked to sequence breaks, but the normal install variant is fully functional.
            Utils.tslPatcherInstructions(modConfig, mod, "Install the Regular Install option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Install"));
        }
    }
}
