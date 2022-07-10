using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Diversified_Jedi_Captives_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the Base installation");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2", "INSTALL"));
        }
    }
}
