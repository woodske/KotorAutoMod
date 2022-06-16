using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Pazaak_UI_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all to the Override folder. Do not overwrite any files
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string> { "assets" }, false);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "assets"), modConfig.SwkotorDirectory, new List<string> { "thin scroll menu for 1920x1080" }, false);

            if (modConfig.SelectedResolution == "1920x1080")
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "assets", "thin scroll menu for 1920x1080"), modConfig.SwkotorDirectory, new List<string> { "assets" }, false);
            }
        }
    }
}
