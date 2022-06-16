using System;
using System.Collections.Generic;

namespace KotorAutoMod
{
    internal static class SupportedMods
    {
        const string Essential = "Essential";
        const string Recommended = "Recommended";
        const string Optional = "Optional";
        /*
         * Managed list of supported mods. This maintains the order in which the mods are applyed to the game.
         */
        public static List<Mod> supportedMods = new List<Mod>
        {
            new Mod(
                "Quicker TSL Patching",
                "xypherh",
                Essential,
                new string[] {"Script-1214-1-0.zip" },
                "Quicker_TSL_Patching_Instructions",
                "Creates a symlink to your swkotor folder for easier use of the TSLPatcher. (This is not a mod)",
                new Uri("https://www.nexusmods.com/kotor/mods/1214")
                ),
            new Mod(
                "KOTOR High Resolution Menus",
                "ndix UR",
                Essential,
                new string[] { "k1hrm-1.5.7z" },
                "KOTOR_High_Resoultion_Menus_Instructions",
                "Scales the UI for widescreen",
                new Uri("https://deadlystream.com/files/file/1159-kotor-high-resolution-menus/")
                ),
            new Mod(
                "Main Menu Widescreen Fix",
                "DarthParametric",
                Essential,
                new string[] { "[K1]_Main_Menu_Widescreen_Fix_v1.2.7z" },
                "Main_Menu_Widescreen_Fix_Instructions",
                "Adjusts the main menu to fit widescreen",
                new Uri("https://deadlystream.com/files/file/1173-k1-main-menu-widescreen-fix/")
                ),
            new Mod(
                "HD Menus and UI Assets",
                "JackInTheBox",
                Essential,
                new string[] { "HD MENU AND UI Art v 1.0.rar" },
                "HD_Menus_And_UI_Assets_Instructions",
                "Overhauls menus and UI at a higher resolution",
                new Uri("https://deadlystream.com/files/file/1457-hd-menus-and-ui-assets/")
                ),
            new Mod(
                "HD Loadscreens (16:9)",
                "ajdrenter",
                Recommended,
                new string[] { "VeryNiceLoadScreens_1.1_16x9.7z" },
                "HD_Loadscreens_Instructions",
                "Replaces default load screens with HD load screens for 16:9 aspect ratio",
                new Uri("https://deadlystream.com/files/file/1472-very-nice-load-screens-for-kotor/")
                ),
            new Mod(
                "HD Loadscreens (4:3)",
                "ajdrenter",
                Recommended,
                new string[] {"VeryNiceLoadScreens_1.1_4x3.7z" },
                "HD_Loadscreens_Instructions",
                "Replaces default load screens with HD load screens for 4:3 aspect ratio",
                new Uri("https://deadlystream.com/files/file/1472-very-nice-load-screens-for-kotor/")
                ),
            new Mod(
                "HD NPC Portraits",
                "ndx UR",
                Recommended,
                new string[] {"hd_npc_portraits-v2.0.7z" },
                "HD_NPC_Portraits_Instructions",
                "Updates NPC portraits with HD portraits",
                new Uri("https://deadlystream.com/files/file/1213-hd-npc-portraits/")
                ),
            new Mod(
                "HD UI Elements",
                "Sdub",
                Recommended,
                new string[] { "Random HD UI Elements.zip", "T3M4 Request.zip" },
                "HD_UI_Elements_Instructions",
                "Adds HD icons for party selection planets on the galaxy map",
                new Uri("https://deadlystream.com/files/file/1909-random-hd-ui-elements/")
                ),

            new Mod(
                "Kashyyk Control Panel",
                "DarthParametric",
                Recommended,
                new string[] { "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1.7z" },
                "Kashyyk_Control_Panel_Instructions",
                "Adds control panel to Kashyyk force field",
                new Uri("https://deadlystream.com/files/file/1427-control-panel-for-kashyyyk-shadowlands-forcefield/")
                ),
            new Mod(
                "HD Carth Onasi",
                "Dark Hope",
                Recommended,
                new string[] { "Carth Onasi.rar" },
                "Carth_Onasi_Instructions",
                "Improves the quality of Carth",
                new Uri("https://deadlystream.com/files/file/1133-hd-carth-onasi/")
                )
        };
    }
}
