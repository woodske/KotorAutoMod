using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Jolee_Bindo_HD_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Download the 1.1 version and move all the files to your Override. Ignore the Icons and Extra Hairy folders.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Quanons Jolee Reskin"), modConfig.SwkotorDirectory, new List<string> { "Extra_Hairy", "Icons", "Read Me.txt" });
        }
    }
}
