using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Republic_Soldiers_New_Shade_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer.
            // If using both components of JC's Republic Soldier Fix mod, install Options 3 and 5;
            // if using only the main component of JC's mod, install only Option 5;
            // if not using JC's mod, install the Main file and Option 2.


            string TSLPatcherPath = Path.Combine(readyMods[0], "[K1]_Republic_Soldier's_New_Shade_v1.1.1", "TSLPatcher");
            if (modConfig.UseAuto)
            {
                if (Utils.isModInstalled("Republic Soldier Fix", modConfig))
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing option 3");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 3);
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing option 5");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 5);
                }
                else
                {
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing the Main option");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 0);
                    Utils.tslPatcherCLIInstructions(modConfig, mod, "Installing option 2");
                    await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath, 2);
                }
            }
            else
            {
                if (Utils.isModInstalled("Republic Soldier Fix", modConfig))
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Choose option 3");
                    await Utils.runExecutable(TSLPatcherPath);
                    Utils.tslPatcherInstructions(modConfig, mod, "Choose option 5");
                    await Utils.runExecutable(TSLPatcherPath);
                }
                else
                {
                    Utils.tslPatcherInstructions(modConfig, mod, "Choose the Main option");
                    await Utils.runExecutable(TSLPatcherPath);
                    Utils.tslPatcherInstructions(modConfig, mod, "Choose option 2");
                    await Utils.runExecutable(TSLPatcherPath);
                }
            }
        }
    }
}
