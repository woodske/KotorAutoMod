using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace KotorAutoMod.Instructions
{
    internal class UniWS_Patcher_Instructions : IInstructions
    {
        public async static void applyMod(string modDirectory, ModConfig modConfig, TextBlock instructionsTextBlock)
        {
            // Run the executable and point it towards your swkotor folder and select the 1024x768 interface. Enter your monitor’s resolution in the boxes and click patch.
            instructionsTextBlock.Text = $"In the Games dropdown select 'Star Wars: KOTOR (1024x768 interface).\n" +
                $"In the Game Installation Folder point to {modConfig.swkotorDirectory}.\n" +
                $"In Screen Width enter {modConfig.selectedResolution.Split("x")[0]}.\n"+
                $"In Height enter {modConfig.selectedResolution.Split("x")[1]}.\n" +
                $"Click Patch";

            string uniwsExecutable = Path.Combine(modDirectory, "uniws.exe");
            await Utils.runExecutable(uniwsExecutable);

            instructionsTextBlock.Text = "";
        }
    }
}
