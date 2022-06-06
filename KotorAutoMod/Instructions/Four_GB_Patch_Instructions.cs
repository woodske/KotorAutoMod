using KotorAutoMod.Models;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Four_GB_Patch_Instructions: IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the executable and point it towards your swkotor.exe
            formActions.updateInstructions($"Point to {Path.Combine(modConfig.swkotorDirectory, "swkotor.exe")}");

            string fourGbPatchExecutable = Path.Combine(modDirectory, "4gb_patch.exe");
            FileUnblocker fileUnblocker = new FileUnblocker();
            fileUnblocker.Unblock(fourGbPatchExecutable);
            await Utils.runExecutable(fourGbPatchExecutable);

            formActions.updateInstructions("");
        }
    }
}
