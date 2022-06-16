using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class KOTOR_Editable_Executable_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move exectuable to swkotor folder
            string swkotorEditableExe = Path.Combine(readyMods[0], "KOTOR Editable Executable", "swkotor.exe");
            File.Copy(swkotorEditableExe, Path.Combine(modConfig.SwkotorDirectory, "swkotor.exe"), true);

            // Open swconfig and change resolution to 1280x1084 and enable V-sync
            modConfig.Instructions = "Select 1280x1024 resolution.\n" +
                "Enable V-Sync.\n" +
                "Hit 'Apply' then 'Close'";

            string swconfigExecutable = Path.Combine(modConfig.SwkotorDirectory, "swconfig.exe");
            await Utils.runExecutable(swconfigExecutable);

            modConfig.Instructions = "";

            // Open swkotor.ini and change the game's resolution to your resolution
            string swkotorIniFile = Path.Combine(modConfig.SwkotorDirectory, "swkotor.ini");

            string width = modConfig.SelectedResolution.Split("x")[0];
            string height = modConfig.SelectedResolution.Split("x")[1];
            string text = File.ReadAllText(swkotorIniFile);

            text = Regex.Replace(text, "(?<=Width=).*?(?=\n)", width);
            text = Regex.Replace(text, "(?<=Height=).*?(?=\n)", height);

            File.WriteAllText(swkotorIniFile, text);
        }
    }
}
