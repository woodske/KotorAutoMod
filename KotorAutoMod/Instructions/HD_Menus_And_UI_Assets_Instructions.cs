using System.IO;

namespace KotorAutoMod.Instructions
{
    internal class HD_Menus_And_UI_Assets_Instructions : IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Move all from For Override to the Override folder
            Utils.moveAllToOverrideDirectory(Path.Combine(modDirectory, "HD MENU AND UI Art v 1.0"), modConfig.swkotorDirectory);
        }
    }
}
