using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Sherruk_With_Lightsabers_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Task.Run(() => File.Copy(readyMods[0], Path.Combine(modConfig.SwkotorDirectory, "Override", Path.GetFileName(readyMods[0])), true));
        }
    }
}
