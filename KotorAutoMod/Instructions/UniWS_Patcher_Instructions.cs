using System.IO;

namespace KotorAutoMod.Instructions
{
    internal class UniWS_Patcher_Instructions : IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the executable and point it towards your swkotor folder and select the 1024x768 interface. Enter your monitor’s resolution in the boxes and click patch.
            formActions.updateInstructions($"In the Games dropdown select 'Star Wars: KOTOR (1024x768 interface).\n" +
                $"In the Game Installation Folder point to {modConfig.swkotorDirectory}.\n" +
                $"In Screen Width enter {modConfig.selectedResolution.Split("x")[0]}.\n"+
                $"In Height enter {modConfig.selectedResolution.Split("x")[1]}.\n" +
                $"Click Patch");

            string uniwsExecutable = Path.Combine(modDirectory, "uniws.exe");
            Utils.runExecutable(uniwsExecutable);

            formActions.updateInstructions("");
        }
    }
}
