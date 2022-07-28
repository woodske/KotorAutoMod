using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_JCs_Minor_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the Override folder from Resolution Fixes, Straight Fixes, and Aesthetic Improvements
            // Move everything from the "Things what bother me" folder as well, EXCEPT the files for the Sith uniform changes:
            // N_AdmrlSaulKar.mdl, N_AdmrlSaulKar.mdx, N_SithComF.mdl, N_SithComF.mdx, N_SithComM.mdl, and N_SithComM.mdx (in other words, move all "MAN26" files and the two "plc_kiosk" files at the bottom)
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            string[] subFolders = new string[] { "Resolution Fixes", "Straight Fixes", "Aesthetic Improvements" };

            foreach (string subFolder in subFolders)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], subFolder), modConfig.SwkotorDirectory);
            }

            await Utils.moveAllToOverrideDirectory(
                Path.Combine(readyMods[0], "Things What Bother Me Fixes"),
                modConfig.SwkotorDirectory,
                new List<string> {
                    "N_AdmrlSaulKar.mdl",
                    "N_AdmrlSaulKar.mdx",
                    "N_SithComF.mdl",
                    "N_SithComF.mdx",
                    "N_SithComM.mdl",
                    "N_SithComM.mdx"
                });
        }
    }
}
