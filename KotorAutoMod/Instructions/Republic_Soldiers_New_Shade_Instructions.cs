using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Republic_Soldiers_New_Shade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install options 3 and 5 for JC’s Republic Soldier Fix.
            Utils.tslPatcherInstructions(modConfig, mod, "Install option 3 (there will be one more after this)");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));

            Utils.tslPatcherInstructions(modConfig, mod, "Install option 5");
            await Utils.runExecutable(Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher"));
        }
    }
}
