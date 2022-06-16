using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class HD_Loadscreens_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to the Override folder. Check that the selected apsect ratio matches the mod.
            string expectedAspectRatio = mod.ModFileName[0].Contains("16x9") ? "16:9" : "4:3";
            if (modConfig.SelectedAspectRatio != expectedAspectRatio)
            {
                string message = $"Unable to apply mod {mod.ListName}. Your selected aspect ratio is {modConfig.SelectedAspectRatio} and this mod requires {expectedAspectRatio}.\n\n" +
                    "All other mods will continue to be applied after closing this dialog.";
                MessageBox.Show(message, "Mod error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            string[] folders = new string[] { "bos", "jc2mando", "jorak", "kotor" };
            foreach (string folder in folders)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], folder), modConfig.SwkotorDirectory);
            }
        }
    }
}
