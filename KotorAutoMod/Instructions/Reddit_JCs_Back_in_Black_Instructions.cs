using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_JCs_Back_in_Black_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer.
            // If running the Community Patch (you should be), install the Community Patch-Compatible install option; otherwise, select Basic.
            // If you would like Master Uthar or Yuthura Ban (the two top Sith at the academy) to wear alternate outfits instead of robes, re-run the patcher to select your preferred options AFTER running the initial install.          
            Utils.openUrl(mod.ModPage[0]);
            MessageBoxResult result = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes if you would like to install alternate outfits, choose no if not.\n\n" +
                "See the mod page for examples.",
                "Additional outfit choices",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            Utils.tslPatcherInstructions(modConfig, mod, "Select the \"Community Patch-Compatible\" install option if you used the K1 community patch (you should have). Otherwise, choose \"Basic\".");
            await Utils.runExecutable(Path.Combine(readyMods[0], "Korriban_Back_in_Black_K1"));

            if (result == MessageBoxResult.Yes)
            {
                Process.Start("explorer.exe", readyMods[0]);
                Utils.tslPatcherInstructions(modConfig, mod, "Install your desired appearance change mods");
                MessageBox.Show(
                    $"Install your desired appearance changes for {mod.ListName} now.\n" +
                    "Keep this window open until you are done, then close it.\n\n" +
                    "To install your appearance changes, run the installer (Korriban_Back_in_Black_K1.exe) which can be found here:\n\n" +
                    $"{readyMods[0]}",
                    "Paused for additional installations",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
            }
        }
    }
}
