using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Mullet_Man_Retexture_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Mullet Man Retexture", "zm_mulletman"), modConfig.SwkotorDirectory, new List<string> { "readme.rtf" });
        }
    }
}
