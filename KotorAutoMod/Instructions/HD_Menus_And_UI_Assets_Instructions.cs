using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Menus_And_UI_Assets_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all from For Override to the Override folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "HD MENU AND UI Art v 1.0"), modConfig.SwkotorDirectory);
        }
    }
}
