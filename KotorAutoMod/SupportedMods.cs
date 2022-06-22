using System;
using System.Collections.Generic;

namespace KotorAutoMod
{
    internal static class SupportedMods
    {
        // Tiers
        const string Essential = "Essential";
        const string Recommended = "Recommended";
        const string Optional = "Optional";

        // Types
        const string Menu = "Menus";
        const string UI = "UI";
        const string Movies = "Movies";
        const string Bug = "Bug Fix";
        const string QoL = "QoL";
        const string Graphics = "Graphics Improvements";
        const string Gameplay = "Gameplay Improvements";

        /*
         * Managed list of supported mods. This maintains the order in which the mods are applyed to the game.
         */
        public static List<Mod> supportedMods = new List<Mod>
        {
            new Mod(
                "Quicker TSL Patching",
                "xypherh",
                QoL,
                Essential,
                new string[] {"Script-1214-1-0.zip" },
                "Quicker_TSL_Patching_Instructions",
                "Creates a symlink to your swkotor folder for easier use of the TSLPatcher. (This is not a mod)",
                new Uri("https://www.nexusmods.com/kotor/mods/1214")
                ),
            new Mod(
                "KOTOR High Resolution Menus",
                "ndix UR",
                Menu,
                Essential,
                new string[] { "k1hrm-1.5.7z" },
                "KOTOR_High_Resoultion_Menus_Instructions",
                "Scales the UI for widescreen",
                new Uri("https://deadlystream.com/files/file/1159-kotor-high-resolution-menus/")
                ),
            new Mod(
                "Main Menu Widescreen Fix",
                "DarthParametric",
                Menu,
                Essential,
                new string[] { "[K1]_Main_Menu_Widescreen_Fix_v1.2.7z" },
                "Main_Menu_Widescreen_Fix_Instructions",
                "Adjusts the main menu to fit widescreen",
                new Uri("https://deadlystream.com/files/file/1173-k1-main-menu-widescreen-fix/")
                ),
            new Mod(
                "HD Menus and UI Assets",
                "JackInTheBox",
                Menu,
                Essential,
                new string[] { "HD MENU AND UI Art v 1.0.rar" },
                "HD_Menus_And_UI_Assets_Instructions",
                "Overhauls menus and UI at a higher resolution",
                new Uri("https://deadlystream.com/files/file/1457-hd-menus-and-ui-assets/")
                ),
            // HD Loadscreens x2
            new Mod(
                "HD Loadscreens (16:9)",
                "ajdrenter",
                Menu,
                Recommended,
                new string[] { "VeryNiceLoadScreens_1.1_16x9.7z" },
                "HD_Loadscreens_Instructions",
                "Replaces default load screens with HD load screens for 16:9 aspect ratio",
                new Uri("https://deadlystream.com/files/file/1472-very-nice-load-screens-for-kotor/")
                ),
            new Mod(
                "HD Loadscreens (4:3)",
                "ajdrenter",
                Menu,
                Recommended,
                new string[] {"VeryNiceLoadScreens_1.1_4x3.7z" },
                "HD_Loadscreens_Instructions",
                "Replaces default load screens with HD load screens for 4:3 aspect ratio",
                new Uri("https://deadlystream.com/files/file/1472-very-nice-load-screens-for-kotor/")
                ),
            new Mod(
                "HD NPC Portraits",
                "ndx UR",
                UI,
                Recommended,
                new string[] {"hd_npc_portraits-v2.0.7z" },
                "HD_NPC_Portraits_Instructions",
                "Updates NPC portraits with HD portraits",
                new Uri("https://deadlystream.com/files/file/1213-hd-npc-portraits/")
                ),
            new Mod(
                "HD UI Elements",
                "Sdub",
                UI,
                Recommended,
                new string[] { "Random HD UI Elements.zip", "T3M4 Request.zip" },
                "HD_UI_Elements_Instructions",
                "Adds HD icons for party selection planets on the galaxy map",
                new Uri("https://deadlystream.com/files/file/1909-random-hd-ui-elements/")
                ),
            new Mod(
                "Pazaak UI",
                "MadDerp",
                UI,
                Recommended,
                new string[] { "PurePazaakAndStuff_1.3-1281-1-3-1560209417.zip" },
                "Pazaak_UI_Instructions",
                "Upgrades Pazaak UI and other icons",
                new Uri("https://www.nexusmods.com/kotor/mods/1281")
                ),
            new Mod(
                "Upscaled Computer",
                "Dark Hope, Sdub, & Effix",
                UI,
                Optional,
                new string[] { "Upscaled Computer.rar" },
                "Upscaled_Computer_Instructions",
                "Upscales computer interface",
                new Uri("https://deadlystream.com/files/file/2025-upscaled-computer/")
                ),
            new Mod(
                "HD Icon Pack",
                "JackInTheBox",
                UI,
                Recommended,
                new string[] { "KoToR1IconMOD.rar" },
                "HD_Icon_Pack_Instructions",
                "Adds HD item UI icons",
                new Uri("https://deadlystream.com/files/file/1699-kotor1-hd-icon-pack-ver10/")
                ),
            // Remastered Cutscenes x5
            new Mod(
                "HD Cutscenes (720)",
                "Naelavok",
                Movies,
                Essential,
                new string[] { "720.zip" },
                "HD_Cutscenes_Instructions",
                "Adds remastered HD cutscenes",
                new Uri("https://deadlystream.com/files/file/1517-kotor-1-remastered-ai-upscaled-cutscenes/")
                ),
            new Mod(
                "HD Cutscenes (768)",
                "Naelavok",
                Movies,
                Essential,
                new string[] { "768.zip" },
                "HD_Cutscenes_Instructions",
                "Adds remastered HD cutscenes",
                new Uri("https://deadlystream.com/files/file/1517-kotor-1-remastered-ai-upscaled-cutscenes/")
                ),
            new Mod(
                "HD Cutscenes (1080)",
                "Naelavok",
                Movies,
                Essential,
                new string[] { "1080.zip" },
                "HD_Cutscenes_Instructions",
                "Adds remastered HD cutscenes",
                new Uri("https://deadlystream.com/files/file/1517-kotor-1-remastered-ai-upscaled-cutscenes/")
                ),
            new Mod(
                "HD Cutscenes (1440)",
                "Naelavok",
                Movies,
                Essential,
                new string[] { "1440.zip" },
                "HD_Cutscenes_Instructions",
                "Adds remastered HD cutscenes",
                new Uri("https://deadlystream.com/files/file/1517-kotor-1-remastered-ai-upscaled-cutscenes/")
                ),
            new Mod(
                "HD Cutscenes (2160)",
                "Naelavok",
                Movies,
                Essential,
                new string[] { "2160 P1.zip", "2160 P2.zip" },
                "HD_Cutscenes_Instructions",
                "Adds remastered HD cutscenes",
                new Uri("https://deadlystream.com/files/file/1517-kotor-1-remastered-ai-upscaled-cutscenes/")
                ),
            new Mod(
                "HD Legal Screen",
                "Ashton Scorpius",
                Movies,
                Optional,
                new string[] { "K1 HD Legal Widescreen 1080p.7z" },
                "HD_Legal_Screen_Instructions",
                "Converts the legal screen to widescreen",
                new Uri("https://deadlystream.com/files/file/1861-k1-hd-legal-screen/")
                ),
            new Mod(
                "Widescreen Cockpit and Racing",
                "MadDerp",
                Menu,
                Recommended,
                new string[] { "ws models for swkotor-1211-0-22-1550195260.zip" },
                "Widescreen_Cockpit_And_Racing_Instructions",
                "Adjusts models for swoop racing and Ebon Hawk",
                new Uri("https://www.nexusmods.com/kotor/mods/1211")
                ),
            new Mod(
                "Larger Text Fonts",
                "sovietshipgirl",
                UI,
                Recommended,
                new string[] { "LargerTextFontsK1.7z" },
                "Larger_Text_Fonts_Instructions",
                "Increases text fonts for higher resolutions. Only use this if you are playing in ultrawide or 4k.",
                new Uri("https://deadlystream.com/files/file/1891-larger-text-fonts-for-kotor-1/")
                ),
            new Mod(
                "Dialouge Fixes",
                "Salk",
                Bug,
                Recommended,
                new string[] { "KotOR_Dialogue_Fixes_4_0.zip" },
                "Dialouge_Fixes_Instructions",
                "Fixes typos and grammatical issues",
                new Uri("https://deadlystream.com/files/file/1313-kotor-dialogue-fixes/")
                ),
            new Mod(
                "KOTOR 1 Community Patch",
                "Many; maintained by A Future Pilot",
                Bug,
                Essential,
                new string[] { "K1_Community_Patch_v1.9.2.zip" },
                "Kotor_1_Community_Patch_Instructions",
                "Compilation of many bugfix mods",
                new Uri("https://deadlystream.com/files/file/1258-kotor-1-community-patch/")
                ),
            new Mod(
                "JC's Minor Fixes",
                "JCarter426",
                QoL,
                Recommended,
                new string[] { "JC's Minor Fixes for K1 v1.1.zip" },
                "JCs_Minor_Fixes_Instructions",
                "A few QoL improvements",
                new Uri("https://deadlystream.com/files/file/1333-jcs-minor-fixes-for-k1/")
                ),
            new Mod(
                "Party Model Fixes",
                "redrob41",
                Bug,
                Recommended,
                new string[] { "K1 Party Model fixes and HD Bastila by RedRob41.7z" },
                "Party_Model_Fixes_Instructions",
                "Fixes UV mapping for party member textures",
                new Uri("https://deadlystream.com/files/file/1273-party-model-fixes-and-hd-bastila/")
                ),
            new Mod(
                "Children NPC Fixes",
                "N-DReW25",
                Bug,
                Optional,
                new string[] { "Children NPC Fixes.7z" },
                "Children_NPC_Fixes_Instructions",
                "Fixes mismatched skin tones on children NPCs",
                new Uri("https://deadlystream.com/files/file/1984-children-npc-fixes/")
                ),
            new Mod(
                "Item Description Fixes",
                "Marauder",
                Bug,
                Recommended,
                new string[] { "DescFixesK1_1.0.1.zip" },
                "Item_Description_Fixes_Instructions",
                "Fixes grammatical issues and inconsistencies in the descriptions of certain items",
                new Uri("https://deadlystream.com/files/file/1478-item-description-fix-pack-k1/")
                ),
            new Mod(
                "Hidden Bek Control Room",
                "N-DReW25",
                Bug,
                Recommended,
                new string[] { "Bek Control Room Restoration 1.1.zip" },
                "Hidden_Bek_Control_Room_Instructions",
                "If you agree to assassinate Gadon for the Vulkars,  there is a door in the Hidden Bek base that was inaccessible. This mod restores it as well as some dialogue",
                new Uri("https://deadlystream.com/files/file/908-hidden-bek-control-room-restoration/")
                ),
            new Mod(
                "Robe Description Fixes",
                "StellarExile",
                Bug,
                Optional,
                new string[] { "Robe Description Fixes.7z" },
                "Robe_Description_Fixes_Instructions",
                "Changes jedi robe description to remove max DEX bonus as it does not actually apply",
                new Uri("https://deadlystream.com/files/file/2029-robe-description-fixes/")
                ),
            new Mod(
                "Kashyyk Control Panel",
                "DarthParametric",
                Bug,
                Recommended,
                new string[] { "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1.7z" },
                "Kashyyk_Control_Panel_Instructions",
                "Adds control panel to Kashyyk force field",
                new Uri("https://deadlystream.com/files/file/1427-control-panel-for-kashyyyk-shadowlands-forcefield/")
                ),
            new Mod(
                "JC's Security Spikes",
                "JCarter426",
                Bug,
                Recommended,
                new string[] { "JC's Security Spikes for K1 v1.2.zip" },
                "JC's_Security_Spikes_Instructions",
                "Security spikes sadly don’t work on the PC version of KOTOR likely due to GUI changes when porting it from the Xbox. This mod adds in a potential workaround. The player can either use them as a consumable item that boosts their security skill or replace them with credits.",
                new Uri("https://deadlystream.com/files/file/1439-jcs-security-spikes-for-k1/")
                ),
            new Mod(
                "Ebon Hawk Camera Replacement",
                "LDR",
                QoL,
                Recommended,
                new string[] { "ebon_hawk_camera.zip" },
                "Ebon_Hawk_Camera_Replacement_Instructions",
                "On the Ebon Hawk the camera is horrendously close to the player. This mod adjusts the angle so it is the same as in other areas.",
                new Uri("https://deadlystream.com/files/file/827-ebon-hawk-camera-replacement/")
                ),
            new Mod(
                "JC's Republic Soldier Fix",
                "JCarter426",
                QoL,
                Recommended,
                new string[] { "JC's Republic Soldier Fix for K1 v1.3.zip" },
                "JC's_Republic_Soldier_Fix_Instructions",
                "The vanilla clothing for the soldiers is absolutely atrocious. This mod replaces the default soldier clothing with the Republic soldier’s uniforms as well as providing higher resolution versions for them.",
                new Uri("https://deadlystream.com/files/file/1180-jcs-republic-soldier-fix-for-k1/")
                ),
            new Mod(
                "Weapon Base Stats Rebalance",
                "TK-664",
                Gameplay,
                Recommended,
                new string[] { "Weapon Base Stats Re-balance K1.rar" },
                "Weapon_Base_Stats_Rebalance_Instructions",
                "In vanilla, blasters are underpowered compared to melee weapons. This mod increases the damage output from blasters so they are similar to their KOTOR 2 counterparts.",
                new Uri("https://deadlystream.com/files/file/1248-weapon-base-stats-re-balance-k1/")
                ),
            new Mod(
                "Persuade Unlocked",
                "Sdub",
                Gameplay,
                Recommended,
                new string[] { "Persuade Unlocked 1.1.zip" },
                "Persuade_Unlocked_Instructions",
                "Persuade is arguably the most important class in KOTOR. Sadly, it is only a class talent for scoundrels even though it is solely used by the player and all classes benefit from it. This mod makes it a class skill to all three classes.",
                new Uri("https://deadlystream.com/files/file/1900-persuade-unlocked/")
                ),
            new Mod(
                "Sneak Attack X Restoration",
                "N-DReW25",
                Gameplay,
                Optional,
                new string[] { "Sneak Attack 10 Restoration.zip" },
                "Sneak_Attack_X_Restoration_Instructions",
                "There was originally a tenth tier of Sneak Attack available. This mod restores it.",
                new Uri("https://deadlystream.com/files/file/1124-sneak-attack-10-restoration/")
                ),
            new Mod(
                "Improved Feat Gain",
                "Mellowtron11",
                Gameplay,
                Recommended,
                new string[] { "KOTOR 1 Improved Feat Gain Mod.zip" },
                "Improved_Feat_Gain_Instructions",
                "The feat gains per level of the Jedi Sentinel and Jedi Guardian are atrociously slow. This mod improves their gains so they are more in line with their KOTOR 2 progression.",
                new Uri("https://deadlystream.com/files/file/1490-kotor-1-improved-feat-gain-mod-10/")
                ),
            new Mod(
                "Improved Grenades",
                "jc2",
                Gameplay,
                Recommended,
                new string[] { "Improved Grenades.7z" },
                "Improved_Grenades_Instructions",
                "Grenades don’t do much damage, especially when facing higher level enemies. This mod adds the user’s demolitions skill as a damage bonus and increases the damage radius slightly so they are more useful for you and for enemies.",
                new Uri("https://deadlystream.com/files/file/1191-improved-grenades/")
                ),
            new Mod(
                "Health Regeneration",
                "MVacc224",
                Gameplay,
                Recommended,
                new string[] { "Health Regeneration.zip" },
                "Health_Regeneration_Instructions",
                "Ever bothered by the fact that you can’t regenerate health outside of combat and the only way is to return to the hideout/Ebon Hawk? Well, now you can!",
                new Uri("https://deadlystream.com/files/file/458-health-regeneration/")
                ),
            new Mod(
                "Saber Throw Knockdown",
                "uwadmin12",
                Gameplay,
                Recommended,
                new string[] { "saberthrow_kd.zip" },
                "Saber_Throw_Knockdown_Instructions",
                "The throw lightsaber power isn’t as nearly as useful as others. This mod gives it a little extra power by adding a knockdown effect.",
                new Uri("https://deadlystream.com/files/file/1487-k1-saber-throw-knockdown-effect/")
                ),
            //new Mod(
            //    "HD Carth Onasi",
            //    "Dark Hope",
            //    Graphics,
            //    Recommended,
            //    new string[] { "Carth Onasi.rar" },
            //    "Carth_Onasi_Instructions",
            //    "Improves the quality of Carth",
            //    new Uri("https://deadlystream.com/files/file/1133-hd-carth-onasi/")
            //    )
        };
    }
}
