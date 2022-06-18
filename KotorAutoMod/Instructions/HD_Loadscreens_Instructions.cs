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
            bool applyMod = true;
            string expectedAspectRatio = mod.ModFileName[0].Contains("16x9") ? "16:9" : "4:3";
            if (modConfig.SelectedAspectRatio != expectedAspectRatio)
            {
                string message = $"Attempting to apply mod {mod.ListName}. Your selected aspect ratio is {modConfig.SelectedAspectRatio} and this mod requires {expectedAspectRatio}.\n\n" +
                    "Press 'Yes' if you want to apply this mod anyways, press 'No' to skip this mod and continue applying the rest.";
                MessageBoxResult messageBoxResult = MessageBox.Show(message, "Incorrect aspect ratio", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (messageBoxResult == MessageBoxResult.No)
                {
                    applyMod = false;
                }
            }

            if (applyMod)
            {
                Utils.copyFilesToOverrideInstructions(modConfig, mod);
                string[] folders = new string[] { "bos", "jc2mando", "jorak", "kotor" };
                foreach (string folder in folders)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], folder), modConfig.SwkotorDirectory);
                }
            }
        }
    }
}
