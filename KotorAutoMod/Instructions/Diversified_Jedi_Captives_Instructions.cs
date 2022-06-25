using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Diversified_Jedi_Captives_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer for the main mod and captive on Dantooine. Move the compatibility patch files to override.
            Utils.tslPatcherInstructions(modConfig, mod, "Install the base installation");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2", "INSTALL"));

            Utils.tslPatcherInstructions(modConfig, mod, "Install the captives mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2", "INSTALL"));

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "[K1]_Diversified_Jedi_Captives_on_the_SF_JC_TSL_Robes_Compatibility_Patch", "FOR OVERRIDE"), modConfig.SwkotorDirectory);
        }
    }
}
