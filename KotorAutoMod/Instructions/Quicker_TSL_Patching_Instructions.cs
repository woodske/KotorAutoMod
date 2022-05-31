using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KotorAutoMod.Instructions
{
    internal class Quicker_TSL_Patching_Instructions : IInstructions
    {
        public async static void applyMod(string modDirectory, ModConfig modConfig, TextBlock instructionsTextBlock)
        {
            // Run the executable
            instructionsTextBlock.Text = "Follow the instructions provided by the tool";

            await Task.Run(() =>
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.Combine(modDirectory, "KotOR_Linker.vbs");
                startInfo.UseShellExecute = true;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            });

            instructionsTextBlock.Text = "";
        }
    }
}
