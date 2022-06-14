using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<Mod> supportedMods()
        {
            List<Mod> supportedMods = new List<Mod>();
            supportedMods.Add(new Mod(
                "Quicker TSL Patching",
                "xypherh",
                Essential,
                "Script-1214-1-0.zip",
                "Quicker_TSL_Patching_Instructions",
                "Creates a symlink to your swkotor folder for easier use of the TSLPatcher. (This is not a mod)",
                new Uri("https://www.nexusmods.com/kotor/mods/1214")
                ));
            supportedMods.Add(new Mod(
                "KOTOR High Resolution Menus",
                "ndix UR",
                Essential,
                "k1hrm-1.5.7z",
                "KOTOR_High_Resoultion_Menus_Instructions",
                "Scales the UI for widescreen",
                new Uri("https://deadlystream.com/files/file/1159-kotor-high-resolution-menus/")
                ));
            supportedMods.Add(new Mod(
                "Main Menu Widescreen Fix",
                "DarthParametric",
                Essential,
                "[K1]_Main_Menu_Widescreen_Fix_v1.2.7z",
                "Main_Menu_Widescreen_Fix_Instructions",
                "Adjusts the main menu to fit widescreen",
                new Uri("https://deadlystream.com/files/file/1173-k1-main-menu-widescreen-fix/")
                ));
            supportedMods.Add(new Mod(
                "HD Menus and UI Assets",
                "JackInTheBox",
                Essential,
                "HD MENU AND UI Art v 1.0.rar",
                "HD_Menus_And_UI_Assets_Instructions",
                "Overhauls menus and UI at a higher resolution",
                new Uri("https://deadlystream.com/files/file/1457-hd-menus-and-ui-assets/")
                ));




            supportedMods.Add(new Mod(
                "Kashyyk Control Panel",
                "DarthParametric",
                Recommended,
                "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1.7z",
                "Kashyyk_Control_Panel_Instructions",
                "Adds control panel to Kahyyk force field",
                new Uri("https://deadlystream.com/files/file/1427-control-panel-for-kashyyyk-shadowlands-forcefield/")
                ));
            supportedMods.Add(new Mod(
                "HD Carth Onasi",
                "Dark Hope",
                Recommended,
                "Carth Onasi.rar",
                "Carth_Onasi_Instructions",
                "Improves the quality of Carth",
                new Uri("https://deadlystream.com/files/file/1133-hd-carth-onasi/")
                ));

            return supportedMods;
        }
    }
}
