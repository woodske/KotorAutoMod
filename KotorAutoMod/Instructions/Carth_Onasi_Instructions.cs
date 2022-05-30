using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Carth_Onasi_Instructions : IInstructions
    {
        public static void applyMod(string modDirectory, ModConfig modConfig)
        {
            // Move all except po_carth to the Override folder
            List<string> excludeList = new List<string>();
            excludeList.Add("PO_pcarth.tga");
            Utils.moveAllToOverrideDirectory(modDirectory, modConfig.swkotorDirectory, excludeList);
        }
    }
}
