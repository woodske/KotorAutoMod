using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class HD_Icons_for_Extra_Saber_Colors_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //  Move the files to your Override, replacing the ones already there, and then move the alternate viridian files to your Override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "HD Icons for JC's Saber Colors", "Icons"), modConfig.SwkotorDirectory, new List<string> { "Alternate Viridian" });
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "HD Icons for JC's Saber Colors", "Icons", "Alternate Viridian"), modConfig.SwkotorDirectory);
        }
    }
}
