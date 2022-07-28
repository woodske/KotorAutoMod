using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ajunta_Palls_Blade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Install the Sith Specter/Rece compatibility option if using Ajunta Pall's Swords.
            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                if (Utils.isModInstalled("Ajunta Pall's Swords", modConfig))
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Sith Specter/Rece compatibility option");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
                }
                else
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the base option");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
                }
            }
            else
            {
                if (Utils.isModInstalled("Ajunta Pall's Swords", modConfig))
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Install the Sith Specter/Rece compatibility option");
                    await Utils.runExecutable(TSLPatcherPath);
                }
                else
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Install the base option");
                    await Utils.runExecutable(TSLPatcherPath);
                }

            }
        }
    }
}
