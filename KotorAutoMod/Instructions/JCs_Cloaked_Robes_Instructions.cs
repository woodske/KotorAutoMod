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
            string TSLPatcherPath = Path.Combine(readyMods[0], "Fashion_I_Cloaked_Jedi_Robes_K1");
            if (modConfig.UseAuto)
            {
                // default to brown-red-blue alternative
                Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing Brown-Red-Blue Alternative");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, $"Check the mod page for examples of the different options: {mod.ModPage}\n\nBrown-Red-Blue Alternative is recommended");

                // Utils.openUrl(mod.ModPage[0]);
                MessageBoxResult result = MessageBox.Show(
                    "If you choose 100% brown, there is a patch in a later mod so remember your choice.",
                    "Reminder",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
                await Utils.runExecutable(TSLPatcherPath);
            }

        }
    }
}
