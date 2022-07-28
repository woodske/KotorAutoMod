using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Canderous_Ordo_and_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Ignore the New Clothes version and download the main and move the files to your Override except for “PO_Canderous.”
            // Then download the patch and move it to your Override to replace the one there (this is to fix a transparency issue on the texture).
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "PO_pcanderous.tga" });

            // patch
            await Task.Run(() => File.Copy(readyMods[1], Path.Combine(modConfig.SwkotorDirectory, "Override", Path.GetFileName(readyMods[1])), true));
        }
    }
}
