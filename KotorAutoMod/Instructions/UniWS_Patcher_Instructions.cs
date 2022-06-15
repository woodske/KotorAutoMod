using KotorAutoMod.ViewModels;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class UniWS_Patcher_Instructions : IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Run the executable and point it towards your swkotor folder and select the 1024x768 interface. Enter your monitor’s resolution in the boxes and click patch.
            string width = modConfig.SelectedResolution.Split("x")[0];
            string height = modConfig.SelectedResolution.Split("x")[1];

            modConfig.Instructions = "Select the following configurations in the Universal Widescreen Patcher tool.\n" +
                $"In the Game dropdown select 'Star Wars: KOTOR (1024x768 interface).\n" +
                $"In the Game Installation Folder point to {modConfig.SwkotorDirectory}.\n" +
                $"In Screen Width enter {width}.\n" +
                $"In Height enter {height}.\n" +
                $"Click Patch and wait for the prompt for a successful patch.\n" +
                "Close the Universal Widescreen Patcher tool.";

            string uniwsExecutable = Path.Combine(modDirectory, "uniws.exe");
            await Utils.runExecutable(uniwsExecutable);
        }
    }
}
