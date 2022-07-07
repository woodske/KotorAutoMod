using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_KOTOR_Dialouge_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move dialog.tlk from 'PC Response Moderation' to the swkotor folder
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Task.Run(() => File.Copy(Path.Combine(readyMods[0], "PC Response Moderation version", "dialog.tlk"), Path.Combine(modConfig.SwkotorDirectory, "dialog.tlk"), true));
        }
    }
}
