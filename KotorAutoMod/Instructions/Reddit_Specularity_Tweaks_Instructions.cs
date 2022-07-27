using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Specularity_Tweaks_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer. After installing this mod, navigate to the Override directory and delete the installed files "PLC_CompPnl.tpc", "PLC_CompPnl2.tpc", and "PLC_footLker.tpc".

            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Placeables_Specularity_Tweaks_v0.1.0", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod);
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod);
                await Utils.runExecutable(TSLPatcherPath);
            }

            await Utils.deleteFromOverride(modConfig, new string[] { "PLC_CompPnl.tpc", "PLC_CompPnl2.tpc", "PLC_footLker.tpc" });
        }
    }
}
