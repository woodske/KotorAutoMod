using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Carth_Onasi_Instructions : IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Move all except po_carth to the Override folder
            List<string> excludeList = new List<string>();
            excludeList.Add("PO_pcarth.tga");
            await Utils.moveAllToOverrideDirectory(modDirectory, modConfig.swkotorDirectory, excludeList);
        }
    }
}
