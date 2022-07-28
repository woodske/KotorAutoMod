using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Quanons_Canderous_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move only P_CandH01.tga to your override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "Quanon_CandOrdo_Reskin", "P_CandH01.tga"), Path.Combine(modConfig.SwkotorDirectory, "Override", "P_CandH01.tga"), true));
        }
    }
}
