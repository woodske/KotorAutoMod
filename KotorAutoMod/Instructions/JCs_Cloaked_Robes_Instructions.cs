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
    internal class JCs_Cloaked_Robes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, $"Check the mod page for examples of the different options: {mod.ModPage}\n\nBrown-Red-Blue Alternative is recommended");
            Utils.openUrl(mod.ModPage);
            MessageBoxResult result = MessageBox.Show(
                "If you choose 100% brown, there is a patch in a later mod so remember your choice.",
                "Reminder",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
            await Utils.runExecutable(Path.Combine(readyMods[0], "Fashion_I_Cloaked_Jedi_Robes_K1"));
        }
    }
}
