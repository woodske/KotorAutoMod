using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Kashyyk_Control_Panel_Instructions: IInstructions
    {
        public static void applyMod(string modDirectory, ModConfig modConfig)
        {
            // Run the installer
            Utils.executeInstall(Path.Combine(modDirectory, "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1", "INSTALL"));
        }
    }
}
