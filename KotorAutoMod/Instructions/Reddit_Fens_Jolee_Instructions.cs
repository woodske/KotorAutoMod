using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Fens_Jolee_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move ONLY P_joleeh01.tga and P_joleeh01.txi to your override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(
                Path.Combine(readyMods[0], "Fens - Jolee", "Fens - Jolee"),
                modConfig.SwkotorDirectory,
                new List<string> {
                    "P_JoleeBB01.tga",
                    "P_JoleeBB01.txi",
                    "PO_pjolee.tga",
                    "po_pjolee3.tga"
                });
        }
    }
}
