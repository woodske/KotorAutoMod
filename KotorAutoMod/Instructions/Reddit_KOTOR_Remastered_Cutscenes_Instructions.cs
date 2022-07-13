using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_KOTOR_Remastered_Cutscenes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Copy all to the movies directory
            string message = $"Copying files from {mod.ListName} to the movies folder.\n" +
                "No actions needed, this may take a couple of minutes depending on your resolution.";
            modConfig.Instructions = message;

            await Utils.moveAllToMoviesDirectory(readyMods[0], modConfig.SwkotorDirectory);
        }
    }
}
