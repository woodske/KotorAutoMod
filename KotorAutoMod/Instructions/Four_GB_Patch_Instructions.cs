using System.IO;
using System.Windows.Controls;

namespace KotorAutoMod.Instructions
{
    internal class Four_GB_Patch_Instructions: IInstructions
    {
        public async static void applyMod(string modDirectory, ModConfig modConfig, TextBlock instructionsTextBlock)
        {
            // Run the executable and point it towards your swkotor.exe
            instructionsTextBlock.Text = $"Point to {Path.Combine(modConfig.swkotorDirectory, "swkotor.exe")}";

            string fourGbPatchExecutable = Path.Combine(modDirectory, "4gb_patch.exe");
            FileUnblocker fileUnblocker = new FileUnblocker();
            fileUnblocker.Unblock(fourGbPatchExecutable);
            await Utils.runExecutable(fourGbPatchExecutable);

            instructionsTextBlock.Text = "";
        }
    }
}
