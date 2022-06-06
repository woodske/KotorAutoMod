using KotorAutoMod.Models;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Kashyyk_Control_Panel_Instructions: IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfig modConfig, FormActions formActions)
        {
            // Run the installer
            await Utils.runExecutable(Path.Combine(modDirectory, "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1", "INSTALL"));
        }
    }
}
