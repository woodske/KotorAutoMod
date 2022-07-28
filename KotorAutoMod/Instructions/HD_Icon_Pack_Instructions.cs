using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Icon_Pack_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all from Override to the Override folder. After, delete all files starting with ia_JediRobe and ia_kghtRobe from the folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "KoToR1IconMOD", "Override"), modConfig.SwkotorDirectory);

            List<string> overrideList = Directory.GetFiles(Path.Combine(modConfig.SwkotorDirectory, "Override")).ToList();
            foreach (String overrideFilePath in overrideList)
            {
                if (overrideFilePath.Contains("ia_JediRobe") || overrideFilePath.Contains("ia_kghtRobe"))
                {
                    File.Delete(overrideFilePath);
                }
            }
        }
    }
}
