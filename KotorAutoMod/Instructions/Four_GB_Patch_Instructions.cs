using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Four_GB_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the executable and point it towards your swkotor.exe
            modConfig.Instructions = $"Point the 4GB patch application to {Path.Combine(modConfig.SwkotorDirectory, "swkotor.exe")}";

            string fourGbPatchExecutable = Path.Combine(readyMods[0], "4gb_patch.exe");
            FileUnblocker fileUnblocker = new FileUnblocker();
            fileUnblocker.Unblock(fourGbPatchExecutable);
            await Utils.runExecutable(fourGbPatchExecutable);
        }
    }
}
