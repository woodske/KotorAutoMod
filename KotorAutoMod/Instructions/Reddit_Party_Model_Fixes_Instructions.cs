using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Party_Model_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //In the "Bastila uvw fix" folder, move all the files from the Bastila Clothes - Option 1 folder into the Override.
            //Move all the files in the Canderous folder.
            //Delete the two .tga files in the Carth folder before moving.
            //Move all the files in the HK-47 folder.
            //Delete the .tga file from the Jolee folder before removing.
            //Ignore the Juhani folder.
            //Move all the files from the Mission folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

            // Bastila
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Bastila uvw fix", "Bastila Clothes (BB) - option1 basic uvw fix"), modConfig.SwkotorDirectory);

            // Canderous
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Canderous uvw fix"), modConfig.SwkotorDirectory, new List<string> { "Read Me - Canderous.txt" });

            // Carth
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Carth uvw fix"), modConfig.SwkotorDirectory, new List<string> { "Read Me - Carth.txt", "P_CarthBB02.tga", "P_CarthBB03.tga" });

            // HK47
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "HK47 uvw fix"), modConfig.SwkotorDirectory, new List<string> { "Read Me - HK47.txt" });

            // Jolee
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Jolee uvw fix"), modConfig.SwkotorDirectory, new List<string> { "Read Me - Jolee.txt", "P_joleeh01.tga" });

            // Mission
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Mission uvw fix"), modConfig.SwkotorDirectory, new List<string> { "Read Me - Mission.txt" });


        }
    }
}
