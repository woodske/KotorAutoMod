using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Reflective_Lightsaber_Blades_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install only the Standard option.
            Utils.tslPatcherInstructions(modConfig, mod, "Install only the Standard option");
            await Utils.runExecutable(Path.Combine(readyMods[0], "New_Lightsaber_Blades_K1_v_1", "TSLPatcher"));
        }
    }
}
