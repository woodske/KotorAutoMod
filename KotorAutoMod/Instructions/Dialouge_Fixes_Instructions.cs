using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Dialouge_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move dialog.tlk from 'Corrections only' to the swkotor folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "Corrections only", "dialog.tlk"), Path.Combine(modConfig.SwkotorDirectory, "dialog.tlk"), true));
        }
    }
}
