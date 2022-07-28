using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_UI_Elements_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the Override folder from both files
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            string hdElementsFolderName = "Random HD UI Elements";
            string[] hdElementsSubFolders = new string[] { "Party Selection", "Planet Icons" };

            foreach (string modFile in readyMods)
            {
                if (modFile.Contains(hdElementsFolderName))
                {
                    foreach (string subFolder in hdElementsSubFolders)
                    {
                        await Utils.moveAllToOverrideDirectory(Path.Combine(modFile, hdElementsFolderName, subFolder), modConfig.SwkotorDirectory);
                    }
                }
                else
                {
                    await Utils.moveAllToOverrideDirectory(modFile, modConfig.SwkotorDirectory);
                }
            }
        }
    }
}
