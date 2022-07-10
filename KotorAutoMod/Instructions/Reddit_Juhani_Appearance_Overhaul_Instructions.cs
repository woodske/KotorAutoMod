using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Juhani_Appearance_Overhaul_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Use the Body & Lightsaber version, we will use a different head model.
            Utils.tslPatcherInstructions(modConfig, mod, "Choose the Body & Lightsaber version only");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Juhani Appearance Overhaul"));
        }
    }
}
