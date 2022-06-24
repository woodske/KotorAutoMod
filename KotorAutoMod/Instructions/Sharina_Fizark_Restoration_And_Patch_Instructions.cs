using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Sharina_Fizark_Restoration_And_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Sharina Fizark Restoration 1.1", "Override"), modConfig.SwkotorDirectory);
            await Task.Run(() => File.Copy(readyMods[1], Path.Combine(modConfig.SwkotorDirectory, "Override", Path.GetFileName(readyMods[1])), true));
        }
    }
}
