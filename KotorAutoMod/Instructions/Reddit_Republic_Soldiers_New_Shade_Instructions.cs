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
    internal class Reddit_Republic_Soldiers_New_Shade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer.
            // If using both components of JC's Republic Soldier Fix mod, install Options 3 and 5; if using only the main component of JC's mod, install only Option 5; if not using JC's mod, install the Main file and Option 2.           
            MessageBoxResult result = MessageBox.Show(
                $"Options for {mod.ListName}:\n" +
                "Choose yes if you are using JC's Republic Soldier Fix mod (the option right before this mod), or no if you skipped it.",
                "Mod choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            if (result == MessageBoxResult.Yes)
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Choose option 3");
                await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));
                Utils.tslPatcherInstructions(modConfig, mod, "Choose option 5");
                await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Choose the Main option");
                await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));
                Utils.tslPatcherInstructions(modConfig, mod, "Choose option 2");
                await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));
            }
        }
    }
}
