﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Kotor_1_Community_Patch_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer. After the installation is finished, go into your override directory and, if present, delete the file "LKA_Leaf03.tpc" before proceeding.
            string TSLPatcherPath = Path.Combine(readyMods[0], "INSTALL.exe");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod, "This will take several minutes to finish.");
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod, "This will take several minutes to finish.");
                await Utils.runExecutable(TSLPatcherPath);
            }

            await Utils.deleteFromOverride(modConfig, new string[] { "LKA_Leaf03.tpc" });
        }
    }
}
