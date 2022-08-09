
using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Quanons_HK47_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all the files except for PO_phk47.tga to your Override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Quanons_HK47_Reskin"), modConfig.SwkotorDirectory, new List<string> { "Read Me.txt", "PO_phk47.tga" });
        }
    }
}
