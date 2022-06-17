using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Cutscenes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Copy all to the movies directory
            string message = $"Copying files from {mod.ListName} to the movies folder.\n" +
                "No actions needed";
            modConfig.Instructions = message;

            await Utils.moveAllToMoviesDirectory(readyMods[0], modConfig.SwkotorDirectory);
            if (readyMods[0].Contains("2160"))
            {
                await Utils.moveAllToMoviesDirectory(readyMods[1], modConfig.SwkotorDirectory);
            }
        }
    }
}
