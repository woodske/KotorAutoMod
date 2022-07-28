using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Ultimate_Character_Overhaul_Patches_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // In order, install the compatch for JC's Minor Fixes, the K1CP, and then all remaining content that matches content you chose to use from the builds.
            // If using Thigh-High Boots for Twi'lek, only move the patch content from the NPC Replacement folder. If using Republic Soldier's New Shade, use the New Shade option.

            // Get installed mods
            bool isInstalled_jcmf = isModInstalled("JC's Minor Fixes", modConfig);
            bool isInstalled_k1cp = isModInstalled("KOTOR Community Patch", modConfig);
            bool isInstalled_bth = isModInstalled("Better Twi'lek Heads", modConfig);
            bool isInstalled_jcma = isModInstalled("JC's Mandalorian Armor", modConfig);
            bool isInstalled_jch = isModInstalled("Juhani Cathar Head", modConfig);
            bool isInstalled_swl = isModInstalled("Sherruk with Lightsabers", modConfig);
            bool isInstalled_thbft = isModInstalled("Thigh - High Boots for Twi'lek", modConfig);
            bool isInstalled_rsns = isModInstalled("Republic Soldier's New Shade", modConfig);

            // JC's Minor Fixes
            if (isInstalled_jcmf)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Aesthetic Improvements"), modConfig.SwkotorDirectory);
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Resolution Fixes"), modConfig.SwkotorDirectory);
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "JC's Minor Fixes - Patch", "Straight Fixes"), modConfig.SwkotorDirectory);
            }

            // K1CP
            if (isInstalled_k1cp)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[1], "KOTOR 1 Community Patch - Patch"), modConfig.SwkotorDirectory);
            }

            // Better Twi'lek Male Heads
            if (isInstalled_bth)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[2], "Better Twi'lek Male Heads - Patch", "Textures"), modConfig.SwkotorDirectory);
            }

            // JC's Mandalorian Armor
            if (isInstalled_jcma)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[3], "JC's Mandalorian Armor - Patch", "Extra Textures"), modConfig.SwkotorDirectory);
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[3], "JC's Mandalorian Armor - Patch", "Option A"), modConfig.SwkotorDirectory);
            }

            // --- Miscellaneous Compatibility Patches
            // Juhani Cathar Head
            if (isInstalled_jch)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[4], "Miscellaneous Compatibility Patches", "Juhani Cathar Head - Patch"), modConfig.SwkotorDirectory);
            }

            // Sherruk with Lightsabers
            if (isInstalled_swl)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[4], "Miscellaneous Compatibility Patches", "Sherruk with Lightsabers - Patch"), modConfig.SwkotorDirectory);
            }

            // Thigh-High Boots for Twi'lek
            if (isInstalled_thbft)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[4], "Miscellaneous Compatibility Patches", "Thigh-High Boots for Twi'lek - Patch", "NPC Replacement"), modConfig.SwkotorDirectory, new List<string> { "Optional" });
            }

            // Republic Soldier's New Shade
            if (isInstalled_rsns)
            {
                await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[5], "Republic Soldier's New Shade - Patch", "New Shade"), modConfig.SwkotorDirectory);
            }
        }

        private bool isModInstalled(string modListName, ModConfigViewModel modConfig)
        {
            return modConfig._mods.Any(mod => mod.ListName.Equals(modListName) && mod.isChecked == true && mod.isAvailable == true);
        }
    }
}
