using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class JC_s_Cloaked_Robes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, $"Check the mod page for examples of the different options: {mod.ModPage}");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Fashion_I_Cloaked_Jedi_Robes_K1"));
        }
    }
}
