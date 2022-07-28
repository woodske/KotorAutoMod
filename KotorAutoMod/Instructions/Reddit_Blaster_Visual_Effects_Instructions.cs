using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Blaster_Visual_Effects_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move everything from the override folder to your game's override directory, unless you would like yellow/green disruptors, in which case those files should be moved from the optional folder after moving all loose files to the override first.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            if (modConfig.UseAuto)
            {
                // default to yellow disrupters
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Override"), modConfig.SwkotorDirectory);
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Optional", "Yellow Disruptors"), modConfig.SwkotorDirectory);
            }
            else
            {
                //Utils.openUrl(mod.ModPage[0]);
                MessageBoxResult result = MessageBox.Show(
                    $"Options for {mod.ListName}:\n" +
                    "Choose yes to use yellow disrupters, no for green disrupters, or cancel to stick with the original.\n\n" +
                    "See the mod page for examples.",
                    "Disrupter color choice",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Question
                    );
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Override"), modConfig.SwkotorDirectory);

                if (result == MessageBoxResult.Yes)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Optional", "Yellow Disruptors"), modConfig.SwkotorDirectory);
                }

                if (result == MessageBoxResult.No)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Optional", "Green Disruptors"), modConfig.SwkotorDirectory);
                }
            }
        }
    }
}
