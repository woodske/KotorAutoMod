using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Ported_Alien_Voiceovers_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the main mod");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Installer"));

            Utils.tslPatcherInstructions(modConfig, mod, "Install the K1CP compatibility patch for the Queedle Fix");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Installer"));
        }
    }
}
