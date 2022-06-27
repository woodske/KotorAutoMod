﻿using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class JCs_Jedi_Tailor_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the installer
            Utils.tslPatcherInstructions(modConfig, mod, "Install the basic installation");
            MessageBoxResult result = MessageBox.Show(
                $"Question for {mod.ListName}:\n" +
                "There is a compatibility patch for this mod depending on your choice for a previous mod: JC's Cloaked Robes.\n" +
                "If your chose the 100% brown option, click yes. Otherwise, click no",
                "Overlay choice",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            await Utils.runExecutable(Path.Combine(readyMods[0], "Jedi_Tailor_K1"));

            if (result == MessageBoxResult.Yes)
            {
                Utils.tslPatcherInstructions(modConfig, mod, "Install compatibility patch");
                await Utils.runExecutable(Path.Combine(readyMods[0], "Jedi_Tailor_K1"));
            }
        }
    }
}
