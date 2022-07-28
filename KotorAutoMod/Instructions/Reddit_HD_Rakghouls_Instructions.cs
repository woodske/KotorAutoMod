using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_HD_Rakghouls_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(
                Path.Combine(readyMods[0], "Emperor Turnip's HD Rakghouls"),
                modConfig.SwkotorDirectory,
                new List<string> {
                    "README.txt",
                    "Screenshot 01.jpg",
                    "Screenshot 02.jpg",
                    "Screenshot 03.jpg",
                    "Screenshot 04.jpg"
                });
        }
    }
}
