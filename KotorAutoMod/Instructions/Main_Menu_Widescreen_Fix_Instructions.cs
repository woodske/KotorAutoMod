using KotorAutoMod.ViewModels;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Main_Menu_Widescreen_Fix_Instructions : IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfigViewModel modConfig)
        {
            // Move all from For Override to the Override folder
            await Utils.moveAllToOverrideDirectory(Path.Combine(modDirectory, "For Override"), modConfig.SwkotorDirectory);
        }
    }
}
