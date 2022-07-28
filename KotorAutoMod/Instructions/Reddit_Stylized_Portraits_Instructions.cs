using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Stylized_Portraits_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override. Choose whether or not to include the PC.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            if (modConfig.UseAuto)
            {
                // default to just companions
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Stylized Portraits by Tinman888", "Override", "Companions"), modConfig.SwkotorDirectory);
            }
            else
            {
                //Utils.openUrl(mod.ModPage[0]);
                MessageBoxResult result = MessageBox.Show(
                    $"Options for {mod.ListName}:\n" +
                    "Choose yes to use PC portrait and companions, or no to just use companions.\n\n" +
                    "See the mod page for examples.",
                    "PC included choice",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question
                    );
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Stylized Portraits by Tinman888", "Override", "Companions"), modConfig.SwkotorDirectory);
                if (result == MessageBoxResult.Yes)
                {
                    await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Stylized Portraits by Tinman888", "Override", "PC"), modConfig.SwkotorDirectory);
                }
            }
        }
    }
}
