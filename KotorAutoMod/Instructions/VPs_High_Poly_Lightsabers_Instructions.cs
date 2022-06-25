using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class VPs_High_Poly_Lightsabers_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all the files except for “w_Dblsbr01.tga” to your Override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "VP's Hi Poly Tin Cans - KotOR 1", "Override"), modConfig.SwkotorDirectory, new List<string> { "w_Dblsbr_001.tga" });
        }
    }
}
