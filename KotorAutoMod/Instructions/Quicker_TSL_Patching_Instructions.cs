using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Quicker_TSL_Patching_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the executable
            modConfig.Instructions = $"Follow the instructions provided by the {mod.ListName} tool. If using 'Auto Apply Mods', this tool is unnecessary and can be closed.";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(readyMods[0], "KotOR_Linker.vbs");
            startInfo.UseShellExecute = true;

            using (Process exeProcess = Process.Start(startInfo))
            {
                await exeProcess.WaitForExitAsync();
            }
        }
    }
}
