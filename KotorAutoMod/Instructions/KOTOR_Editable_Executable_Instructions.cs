using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace KotorAutoMod.Instructions
{
    internal class KOTOR_Editable_Executable_Instructions : IInstructions
    {
        public async static void applyMod(string modDirectory, ModConfig modConfig, TextBlock instructionsTextBlock)
        {
            // Move exectuable to swkotor folder
            string swkotorEditableExe = Path.Combine(modDirectory, "KOTOR Editable Executable", "swkotor.exe");
            File.Copy(swkotorEditableExe, Path.Combine(modConfig.swkotorDirectory, "swkotor.exe"), true);

            // Open swconfig and change resolution to 1280x1084 and enable V-sync
            instructionsTextBlock.Text = $"Select 1280x1084 resolution and enable V-sync";

            string swconfigExecutable = Path.Combine(modConfig.swkotorDirectory, "swconfig.exe");
            await Utils.runExecutable(swconfigExecutable);

            instructionsTextBlock.Text = "";

            // Open swkotor.ini and change the game's resolution to your resolution
            string swkotorIniFile = Path.Combine(modConfig.swkotorDirectory, "swkotor.ini");

            string width = modConfig.selectedResolution.Split("x")[0];
            string height = modConfig.selectedResolution.Split("x")[1];
            string text = File.ReadAllText(swkotorIniFile);

            text = Regex.Replace(text, "(?<=Width=).*?(?=\n)", width);
            text = Regex.Replace(text, "(?<=Height=).*?(?=\n)", height);

            File.WriteAllText(swkotorIniFile, text);
        }
    }
}
