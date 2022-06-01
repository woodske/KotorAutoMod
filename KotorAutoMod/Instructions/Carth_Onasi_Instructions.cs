using System.Collections.Generic;

namespace KotorAutoMod.Instructions
{
    internal class Carth_Onasi_Instructions : IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Move all except po_carth to the Override folder
            List<string> excludeList = new List<string>();
            excludeList.Add("PO_pcarth.tga");
            Utils.moveAllToOverrideDirectory(modDirectory, modConfig.swkotorDirectory, excludeList);
        }
    }
}
