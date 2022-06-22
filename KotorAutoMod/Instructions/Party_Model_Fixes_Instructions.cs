using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Party_Model_Fixes_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move all mdl/mdx files from each uvw fix to override except Juhani. Ignore tga file for Carth, Jolee, and Bastila.
            // For Bastila only install option 1 for the body and the mdl and mdx files from the head folder.
            Utils.copyFilesToOverrideInstructions(modConfig, mod);

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

            // Bastila
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Bastila uvw fix", "Bastila Head"), modConfig.SwkotorDirectory, new List<string> { "P_BastilaH04.tga" });
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Bastila uvw fix", "Bastila Clothes (BB) - option1 basic uvw fix"), modConfig.SwkotorDirectory);
        }
    }
}
