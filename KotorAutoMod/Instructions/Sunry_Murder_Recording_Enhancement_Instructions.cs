﻿using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Sunry_Murder_Recording_Enhancement_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            string TSLPatcherPath = Path.Combine(readyMods[0], "SMRE", "SMRE Installer");

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

            // Manual installation instructions if needed
            //modConfig.Instructions = "Copying file to modules folder";
            //string filePath = Path.Combine(readyMods[0], "SMRE", "Manual Installation", "manm26ae.mod");
            //await Task.Run(() => File.Copy(filePath, Path.Combine(modConfig.SwkotorDirectory, "modules", Path.GetFileName(filePath)), true));
        }
    }
}
