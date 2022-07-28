using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Mission_Vao_and_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the main files except for “PO_pmission” and “po_pmission3” and the ones from “Mission in Shorts” to your Override. These will replace ones already there.
            // Then download the patch and move it to your Override to replace another file (this is to fix a seam issue on the head).
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "Mission in shorts", "Read Me.txt", "PO_pmission.tga", "po_pmission3.tga" });
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Mission in shorts"), modConfig.SwkotorDirectory);

            // patch
            await Task.Run(() => File.Copy(readyMods[1], Path.Combine(modConfig.SwkotorDirectory, "Override", Path.GetFileName(readyMods[1])), true));
        }
    }
}
