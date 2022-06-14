using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Quicker_TSL_Patching_Instructions : IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfigViewModel modConfig)
        {
            // Run the executable
            modConfig.Instructions = "Follow the instructions provided by the tool";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(modDirectory, "KotOR_Linker.vbs");
            startInfo.UseShellExecute = true;

            using (Process exeProcess = Process.Start(startInfo))
            {
                await exeProcess.WaitForExitAsync();
            }
        }
    }
}
