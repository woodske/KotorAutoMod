using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Carth_Onasi_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all except po_carth to the Override folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            List<string> excludeList = new List<string>();
            excludeList.Add("PO_pcarth.tga");
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, excludeList);
        }
    }
}
