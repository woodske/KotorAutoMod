using System.IO;

namespace KotorAutoMod.Instructions
{
    internal class Main_Menu_Widescreen_Fix_Instructions : IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Move all from For Override to the Override folder
            Utils.moveAllToOverrideDirectory(Path.Combine(modDirectory, "For Override"), modConfig.swkotorDirectory);
        }
    }
}
