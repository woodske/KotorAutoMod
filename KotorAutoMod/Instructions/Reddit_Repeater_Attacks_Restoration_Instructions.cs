using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Repeater_Attacks_Restoration_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move k_ai_master.ncs to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(readyMods[0], modConfig.SwkotorDirectory, new List<string>
            {
                "optional",
                "k_ai_master.nss",
                "Readme (pretty).rtf",
                "Readme (txt).txt"
            });
        }
    }
}
