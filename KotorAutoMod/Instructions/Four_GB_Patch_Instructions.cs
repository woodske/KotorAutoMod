using System.IO;

namespace KotorAutoMod.Instructions
{
    internal class Four_GB_Patch_Instructions: IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the executable and point it towards your swkotor.exe
            formActions.updateInstructions($"Point to {Path.Combine(modConfig.swkotorDirectory, "swkotor.exe")}");

            string fourGbPatchExecutable = Path.Combine(modDirectory, "4gb_patch.exe");
            FileUnblocker fileUnblocker = new FileUnblocker();
            fileUnblocker.Unblock(fourGbPatchExecutable);
            Utils.runExecutable(fourGbPatchExecutable);

            formActions.updateInstructions("");
        }
    }
}
