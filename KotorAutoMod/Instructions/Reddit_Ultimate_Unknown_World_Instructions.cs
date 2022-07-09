using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ultimate_Unknown_World_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all files to override. Delete LUN_blst01.tpc and LUN_blst02.tpc before moving to your override.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Ultimate Unknown World High Resolution - TPC Version", "Unknown World HR TPC Ver", "Override"),
                modConfig.SwkotorDirectory,
                new List<string>
                {
                    "LUN_blst01.tpc",
                    "LUN_blst02.tpc"
                });
        }
    }
}
