using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Larger_Text_Fonts_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Only default check box if at higher resolution or widescreen. Default to VeryBig font, show dialog box to inform.
            // Move all files from 'VeryBig' folder to override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            bool applyMod = true;

            string message = $"Attempting to apply mod {mod.ListName}. Defaulting to use the suggested 'Very Big' options.\n\n" +
                $"If this is OK, then press 'Yes' and the mod will be applied. Otherwise, keep this dialog box open, open this mod at {Path.Combine(readyMods[0], "LargerTextFontsK1")}, read the README, and move the font sizes you want into the {modConfig.SwkotorDirectory} folder then press 'No' to continue applying mods\n\n" +
                "Or just press 'No' to skip this mod";
            MessageBoxResult messageBoxResult = MessageBox.Show(message, "Larger Text Fonts Mod", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (messageBoxResult == MessageBoxResult.No)
            {
                applyMod = false;
            }

            if (applyMod)
            {
                string basePath = Path.Combine(readyMods[0], "LargerTextFontsK1", "FONTS");
                string[] folders = new string[] { "Dialogue_Description_VeryBig", "Menu_VeryBig", "Names_VeryBig" };

                foreach (string folder in folders)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(basePath, folder), modConfig.SwkotorDirectory);
                }
            }
        }
    }
}
