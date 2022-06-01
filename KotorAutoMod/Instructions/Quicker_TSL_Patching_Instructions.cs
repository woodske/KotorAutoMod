using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Quicker_TSL_Patching_Instructions : IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the executable
            formActions.updateInstructions("Follow the instructions provided by the tool");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(modDirectory, "KotOR_Linker.vbs");
            startInfo.UseShellExecute = true;

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

            formActions.updateInstructions("");
        }
    }
}
