using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class HD_Yuthura_Ban_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Decide which version you’d like to use, and move the files to your override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            MessageBoxResult result = MessageBox.Show(
                $"There are three options for {mod.ListName}: Original Tattoos, Modified Tattoos, and Without Tattoos. Choose yes for original, no for modified, and cancel for without",
                $"{mod.ListName} options",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Original Tattoos"), modConfig.SwkotorDirectory);
            }
            else if (result == MessageBoxResult.No)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Modified Tattoo"), modConfig.SwkotorDirectory);
            }
            else
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Without tattoos"), modConfig.SwkotorDirectory);
            }
        }
    }
}
