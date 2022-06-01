using System.IO;

namespace KotorAutoMod.Instructions
{
    internal class Kashyyk_Control_Panel_Instructions: IInstructions
    {
        public void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the installer
            Utils.runExecutable(Path.Combine(modDirectory, "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1", "INSTALL"));
        }
    }
}
