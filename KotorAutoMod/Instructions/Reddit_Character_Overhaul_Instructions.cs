using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Character_Overhaul_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Download the TGA version and move the files to your Override except for PFBI01 through PFBI04, and PMBI01 through PMBI04
            Utils.copyFilesToOverrideInstructions(modConfig, mod, "This may take a couple of minutes");
            await Utils.moveAllToOverrideDirectory(
                Path.Combine(readyMods[0], "KOTOR - Ultimate Character Overhaul 4.1"),
                modConfig.SwkotorDirectory,
                new List<string>
                {
                    "PFBI01.tga",
                    "PFBI02.tga",
                    "PFBI03.tga",
                    "PFBI04.tga",
                    "PMBI01.tga",
                    "PMBI02.tga",
                    "PMBI03.tga",
                    "PMBI04.tga",
                });
        }
    }
}
