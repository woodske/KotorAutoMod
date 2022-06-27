using System;
using System.Collections.Generic;

namespace KotorAutoMod
{
    internal static class SupportedMods
    {
        // Tiers
        const string Essential = "Essential";
        const string Recommended = "Recommended";
        const string Suggested = "Suggested";
        const string Optional = "Optional";

        // Types
        const string Menu = "Menus";
        const string UI = "UI";
        const string Movies = "Movies";
        const string Bug = "Bug Fix";
        const string QoL = "QoL";
        const string Graphics = "Graphics Improvements";
        const string Gameplay = "Gameplay Improvements";
        const string Immersion = "Immersion";
        const string Restored = "Restored Content";
        const string Patch = "Patch";
        const string Added = "Added Content";
        const string Story = "Story Change";

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
                "Kashyyyk Control Panel",
                "DarthParametric",
                Bug,
                Recommended,
                new string[] { "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1.7z" },
                "Kashyyyk_Control_Panel_Instructions",
                "Adds control panel to Kashyyyk force field",
                new Uri("https://deadlystream.com/files/file/1427-control-panel-for-kashyyyk-shadowlands-forcefield/")
                ),
            new Mod(
                "JC's Security Spikes",
                "JCarter426",
                Bug,
                Recommended,
                new string[] { "JC's Security Spikes for K1 v1.2.zip" },
                "JCs_Security_Spikes_Instructions",
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
                "JCs_Republic_Soldier_Fix_Instructions",
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
            new Mod(
                "Force Enlightenment",
                "uwadmin12",
                Gameplay,
                Recommended,
                new string[] { "k1_enlightenment.zip" },
                "Force_Enlightenment_Instructions",
                "I couldn’t be the only one disappointed by how similar most of the light side powers were in K1. This mod adds an adaptation of Force Enlightenment from KOTOR 2 where the best of Speed, Aura, and Valor are all activated at reduced cost to increase their usefulness.",
                new Uri("https://deadlystream.com/files/file/1483-k1-force-enlightenment-power/")
                ),
            new Mod(
                "Balanced Pazaak",
                "A Future Pilot",
                Gameplay,
                Recommended,
                new string[] { "Balanced Pazaak.zip" },
                "Balanced_Pazaak_Instructions",
                "Pazaak is pretty rigged. This mod aims to make it as fair as possible by altering opponents' decks.",
                new Uri("https://deadlystream.com/files/file/1270-balanced-pazaak/")
                ),
            new Mod(
                "No Random Fighter Battles",
                "Antonia",
                Gameplay,
                Recommended,
                new string[] { "NO_Fighters.zip" },
                "No_Random_Fighter_Battles_Instructions",
                "When traveling from planet to planet, it always got irritating to be ambushed constantly by Sith fighters from nowhere and play the same minigame repeatedly. This mod removes the minigames when traveling except for story-related ones.",
                new Uri("https://deadlystream.com/files/file/807-no-random-fighter-battles/")
                ),
            new Mod(
                "Davik's Upgradeable Armor",
                "N-DReW25",
                Gameplay,
                Optional,
                new string[] { "Davik&#39;s Upgradable Armor Mod.zip" },
                "Daviks_Upgradeable_Armor_Instructions",
                "Davik’s armor is unique, but unfortunately it isn’t upgradeable. Since most of the items in the game are upgradeable, why wouldn’t Davik’s be?",
                new Uri("https://deadlystream.com/files/file/890-daviks-upgradable-armor-mod/")
                ),
            new Mod(
                "Weapons and Armor Restored",
                "TK-664",
                Gameplay,
                Recommended,
                new string[] { "KOTOR_WNAU_V1_3.rar" },
                "Weapons_and_Armor_Restored_Instructions",
                "Several items are in the game files but don’t actually appear in the game. This mod restores as many as possible in locations that make sense throughout the game.",
                new Uri("https://deadlystream.com/files/file/1921-weapons-armor-uncut/")
                ),
            new Mod(
                "Vulkar Lab Bench",
                "DarthParametric",
                Immersion,
                Optional,
                new string[] { "[K1]_Black_Vulkar_Base_Engine_Lab_Bench_For_Swoop_Accelerator.7z" },
                "Vulkar_Lab_Bench_Instructions",
                "The prototype swoop accelerator the Vulkars stole was idiotically placed on the floor. This mod positions it on a bench and fixes some issues with the area.",
                new Uri("https://deadlystream.com/files/file/1747-black-vulkar-base-engine-lab-bench-for-swoop-accelerator/")
                ),
            new Mod(
                "JC's Vision Enhancement",
                "JCarter426",
                Immersion,
                Recommended,
                new string[] { "JC's Vision Enhancement for K1 v1.2.zip" },
                "JCs_Vision_Enhancement_Instructions",
                "The force visions the player has throughout the game have two inconsistencies. On Taris, the first vision is seen in the Ebon Hawn and all visions have the player sleeping in whatever they have equipped. This mod fixes both oversights.",
                new Uri("https://deadlystream.com/files/file/1402-jcs-vision-enhancement-for-k1/")
                ),
            new Mod(
                "JC's Cloaked Robes",
                "JCarter426",
                Immersion,
                Recommended,
                new string[] { "JC's Fashion Line I - Cloaked Jedi Robes for K1 v1.4.7z" },
                "JCs_Cloaked_Robes_Instructions",
                "Ever tired of the look of KOTOR 1’s robes and wished they actually looked like Jedi robes? This mod ports the robes from KOTOR 2 that more closely resemble the OT’s and recolors them to KOTOR 1’s colors. ",
                new Uri("https://deadlystream.com/files/file/1378-jcs-fashion-line-i-cloaked-jedi-robes-for-k1/")
                ),
            new Mod(
                "Dark Jedi Wear Robes",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Dark_Jedi_Wear_Robes_for_JC's_Cloaked_Robes_v1.01.7z" },
                "Dark_Jedi_Wear_Robes_Instructions",
                "This one grants all of the Dark Jedi in the game robes from JC’s mod.",
                new Uri("https://deadlystream.com/files/file/1411-dark-jedi-wear-robes-for-jcs-cloaked-jedi-robes-mod/")
                ),
            new Mod(
                "Unique Qel-Droma Robes",
                "Effix",
                Immersion,
                Recommended,
                new string[] { "Effixian's Qel-Droma Robes Reskin for JC's Cloaked Jedi Robes.zip" },
                "Unique_Qel-Droma_Robes_Instructions",
                "Gives Qel-Droma robes their own unique texture",
                new Uri("https://deadlystream.com/files/file/2019-effixians-qel-droma-robes-reskin-for-jcs-cloaked-jedi-robes/")
                ),
            new Mod(
                "Rakghoul Fiend",
                "ebmar",
                Gameplay,
                Optional,
                new string[] { "[K1]_Rakghoul_Fiend_v1.0.0.7z" },
                "Rakghoul_Fiend_Instructions",
                "There wasn’t much difference between Rakghoul Fiends and their regular variants. This mod gives Fiends a unique appearance and adjusts their attributes so they are more difficult to defeat.",
                new Uri("https://deadlystream.com/files/file/1445-k1-rakghoul-fiend/")
                ),
            new Mod(
                "Galaxy Map Fix Pack",
                "Kexikus",
                Immersion,
                Optional,
                new string[] { "K1 Galaxy Map Fix Pack.zip", "HR Menu Patch.zip" },
                "Galaxy_Map_Fix_Pack_Instructions",
                "Fixes the positioning of planets on the Ebon Hawk’s galaxy map so they are in their canonical positions.",
                new Uri("https://deadlystream.com/files/file/1068-k1-galaxy-map-fix-pack/")
                ),
            new Mod(
                "Selven Legends",
                "ebmar",
                Gameplay,
                Recommended,
                new string[] { "[K1]_Selven_'Legends'_v1.3.7z" },
                "Selven_Legends_Instructions",
                "For the most dangerous assassin on Taris, Selven really didn't live up to her reputation. This mod overhauls her stats, loot, and appearance so she is much stronger and is well worth the bounty.",
                new Uri("https://deadlystream.com/files/file/1308-k1-selven-legends/")
                ),
            new Mod(
                "Janice Nall Legends",
                "ebmar",
                Immersion,
                Optional,
                new string[] { "[K1]_Legends_Janice_Nall_and_the_Incomplete_Droids_v1.1.1.7z" },
                "Janice_Nall_Legends_Instructions",
                "Gives Janice Nall a unique appearance.",
                new Uri("https://deadlystream.com/files/file/1424-k1-janice-nall-legends-and-the-incomplete-droids/")
                ),
            new Mod(
                "Marlena Venn Legends",
                "ebmar",
                Immersion,
                Optional,
                new string[] { "[K1]_Legends_Marlena_Venn_v1.1.0.7z" },
                "Marlena_Venn_Legends_Instructions",
                "Gives the disgruntled Marlena Venn a unique appearance.",
                new Uri("https://deadlystream.com/files/file/1463-k1-marlena-venn-legends/")
                ),
            new Mod(
                "Lyn Sekla Legends",
                "ebmar",
                Immersion,
                Optional,
                new string[] { "[K1]_Lyn_Sekla_'Legends'_v1.0.1.7z" },
                "Lyn_Sekla_Legends_Instructions",
                "Gives Lyn Sekla her own unique appearance.",
                new Uri("https://deadlystream.com/files/file/1325-k1-lyn-sekla-legends/")
                ),
            new Mod(
                "Shaleena Original Head Restoration",
                "StellarExile",
                Immersion,
                Optional,
                new string[] { "Shaleena Head Restoration.zip" },
                "Shaleena_Original_Head_Restoration_Instructions",
                "Shaleena was originally supposed to have a unique head. This mod restores it.",
                new Uri("https://deadlystream.com/files/file/1896-shaleena-original-head-restoration/")
                ),
            new Mod(
                "Ajunta Pall Unique Appearance",
                "VarsityPuppet",
                Immersion,
                Recommended,
                new string[] { "Spectral_Ajunta_Pall_Canon_Appearance.zip" },
                "Ajunta_Pall_Unique_Appearance_Instructions",
                "It was quite disappointing how Ajunta Pall was basically a generic Dark Jedi with a shield in vanilla. This mod not only gives him a canon-accurate unique appearance but changes his voice.",
                new Uri("https://deadlystream.com/files/file/1276-spectral-ajunta-pall-canonical-appearance/")
                ),
            new Mod(
                "Ajunta Pall's Blade",
                "ebmar",
                Recommended,
                Immersion,
                new string[] { "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b.7z" },
                "Ajunta_Palls_Blade_Instructions",
                "Pall had quite a famous sword. This mod gives it a new rendition so it’s unique.",
                new Uri("https://deadlystream.com/files/file/1338-k1-legends-ajunta-palls-blade/")
                ),
            new Mod(
                "Sherruk With Lightsabers",
                "Milo49, edited by StellarExile",
                Immersion,
                Recommended,
                new string[] { "dan14_sherruk.utc" },
                "Sherruk_With_Lightsabers_Instructions",
                "Sherruk had lightsaber trophies from all the Jedi he killed but didn’t have them equipped. This mod gives him the lightsabers to add a little more life to the fight and ensures you are well rewarded for defeating him. This mod was originally made by Shem, but many (including myself) felt it was too game-breaking.",
                new Uri("https://drive.google.com/file/d/1Rny2eT_-9Vr3mYJLGDFE2qceXA4dEaEx/view")
                ),
            new Mod(
                "Juhani Lightsaber Fix",
                "Mellowtron11",
                Immersion,
                Optional,
                new string[] { "Juhani Lightsaber Fix Mod.zip" },
                "Juhani_Lightsaber_Fix_Instructions",
                "Gives Juhani a blue lightsaber during the duel on Dantooine. It doesn’t really make sense why she would bother to change the color to red.",
                new Uri("https://deadlystream.com/files/file/1453-juhani-lightsaber-fix/")
                ),
            new Mod(
                "Deadeye Duncan Restoration",
                "Seamhainn",
                Restored,
                Optional,
                new string[] { "Duncan on Manaan.7z" },
                "Deadeye_Duncan_Restoration_Instructions",
                "Deadeye Duncan was originally supposed to appear on Manaan with some pretty funny dialogue. This mod restores him.",
                new Uri("https://mega.nz/file/IR4QASTa#V28cTdgcNTMPwPrNbMElbnNVHkqhkKu7vJgL7PWVZ0U")
                ),
            new Mod(
                "Sharina Fizark Restoration & Patch",
                "Sekan, patch by StellarExile",
                Restored,
                Optional,
                new string[] { "sharina_fizark_restoration_1.1.zip", "dan13_zzshari.utc" },
                "Sharina_Fizark_Restoration_And_Patch_Instructions",
                "Sharina Fizark, the woman you can help on Tatooine, was originally supposed to appear on Dantooine once the quest was completed. This mod restores her and some cut dialogue.",
                new Uri("https://www.gamefront.com/games/knights-of-the-old-republic/file/sharina-fizark-restoration-1"),
                "Patch found here: https://drive.google.com/file/d/1bw6uS4vl2JcmNIfDYe8c2nhz4ewV8bPB/view"
                ),
            new Mod(
                "Helena Shan Improvement",
                "VarsityPuppet",
                Immersion,
                Recommended,
                new string[] { "Helena_Shan_Improvement.zip" },
                "Helena_Shan_Improvement_Instructions",
                "Helena Shan looks absolutely nothing like Bastila even though Bastila clearly said she looks like her mother. This mod gives Helena a unique appearance so there is resemblance between her and her daughter.",
                new Uri("https://deadlystream.com/files/file/1218-helena-shan-improvement/")
                ),
            new Mod(
                "Taris Dueling Arena Adjustments",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Taris_Dueling_Arena_Adjustment_v1.3.7z" },
                "Taris_Dueling_Arena_Adjustments_Instructions",
                "The dueling arena on Taris has horribly low-poly sprites and several issues (like the player doesn’t face their opponent). This mod fixes them and makes other adjustments to the area.",
                new Uri("https://deadlystream.com/files/file/1404-taris-dueling-arena-adjustment/")
                ),
            new Mod(
                "Taris Escape Sequence Adjustments",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Taris_Escape_Sequence_Adjustments_v1.2.7z" },
                "Taris_Escape_Sequence_Adjustments_Instructions",
                "Makes several much needed changes and fixes to the escape sequence from Taris.",
                new Uri("https://deadlystream.com/files/file/1192-taris-escape-sequence-adjustments/")
                ),
            new Mod(
                "Dark Side Ending Adjustments",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Dark_Side_Ending_Cutscene_Enhancement.7z" },
                "Dark_Side_Ending_Adjustments_Instructions",
                "Improves the DS ending scene by adding in better sprites and other adjustments.",
                new Uri("https://deadlystream.com/files/file/1958-dark-side-ending-cutscene-enhancement/")
                ),
            new Mod(
                "Light Side Ending Masters",
                "N-DReW25",
                Immersion,
                Optional,
                new string[] { "Ending Fix 1.1.zip" },
                "Light_Side_Ending_Masters_Instructions",
                "During the ending ceremony for the LS ending, there are random Jedi NPCs using player heads. This mod replaces them with Vrook, Zhar, and Dorak.",
                new Uri("https://deadlystream.com/files/file/1376-light-side-ending-masters/")
                ),
            new Mod(
                "Tutorial Remover",
                "darthbdaman",
                Immersion,
                Recommended,
                new string[] { "Tutorial Remover.7z" },
                "Tutorial_Remover_Instructions",
                "Tired of Trask’s shouting tutorials at you? This mod removes Trask altogether so it’s just you fighting your way off the Endar Spire.",
                new Uri("https://deadlystream.com/files/file/1158-tutorial-remover/")
                ),
            new Mod(
                "Logical Datapads",
                "Sdub & ebmar",
                Immersion,
                Recommended,
                new string[] { "Logical Datapads.7z" },
                "Logical_Datapads_Instructions",
                "Datapads are very useful plot items, but there was no real way to tell them apart until now. This mod gives each their own unique title based on their contents (i.e. Hidden Bek Rancor Plan) to make it easier to discern what they are.",
                new Uri("https://deadlystream.com/files/file/2008-logical-datapads/")
                ),
            new Mod(
                "Leviathan Differentiated Dialogue",
                "Revanator",
                Immersion,
                Recommended,
                new string[] { "Leviathan Differentiated Dialogue.7z" },
                "Leviathan_Differentiated_Dialogue_Instructions",
                "On the Leviathan when you play as a companion, you’ll encounter the Rodian prisoner who offers you the ice breaker. The problem is the dialogue is the same for all companions. This mod gives each companion their own unique dialogue based on their personalities.",
                new Uri("https://deadlystream.com/files/file/895-leviathan-differentiated-dialogue/")
                ),
            new Mod(
                "JC's Robe Adjustment",
                "JCarter426",
                Immersion,
                Recommended,
                new string[] { "JC's Robe Adjustment for K1 v1.2.zip" },
                "JCs_Robe_Adjustment_Instructions",
                "Why did the player have to wait until they finished the Grove mission until they got their Jedi robes? This mod gives the player their robes as soon as they have built their lightsaber.",
                new Uri("https://deadlystream.com/files/file/1475-jcs-robe-adjustment-for-k1/")
                ),
            new Mod(
                "JC's Back in Black",
                "JCartrer426",
                Immersion,
                Recommended,
                new string[] { "JC's Korriban - Back in Black for K1 v2.3.zip" },
                "JCs_Back_in_Black_Instructions",
                "The Sith on Korriban never wore the Dark Jedi robes they should have. This mod ensures all Sith students and masters (including Uthar) wear robes instead of officer uniforms.",
                new Uri("https://deadlystream.com/files/file/1293-jcs-korriban-back-in-black-for-k1/")
                ),
            new Mod(
                "Senni Vek Restoration",
                "N-DReW25",
                Immersion,
                Optional,
                new string[] { "Senni Vek Restoration.zip" },
                "Senni_Vek_Restoration_Instructions",
                "Senni Vek was the original initiator of the GenoHaradan questline, so why didn’t he appear during the final showdown with Hulas? This mod restores him to the final battle on Tatooine.",
                new Uri("https://deadlystream.com/files/file/1090-senni-vek-restoration/")
                ),
            new Mod(
                "Sith Soldier Texture Restoration",
                "A Future Pilot",
                Immersion,
                Optional,
                new string[] { "Sith Soldier Texture Restoration-v2.4.zip" },
                "Sith_Soldier_Texture_Restoration_Instructions",
                "There is an unused texture in the game files for Sith Elite Troopers. This mod restores it to differentiate between Elite and Heavy troopers so Elite troopers no longer wear red armor.",
                new Uri("https://deadlystream.com/files/file/1289-sith-soldier-texture-restoration/")
                ),
            new Mod(
                "Female Republic Soldier Restoration",
                "N-DReW25",
                Immersion,
                Optional,
                new string[] { "Female Republic Soldier RestorationA.7z" },
                "Female_Republic_Soldier_Restoration_Instructions",
                "Female republic soldiers were cut despite being in the game files. This mod restores them in several places.",
                new Uri("https://deadlystream.com/files/file/2022-female-republic-soldier-restoration/")
                ),
            new Mod(
                "Korriban Workbench",
                "InSidious",
                Gameplay,
                Optional,
                new string[] { "di_kaw2.7z" },
                "Korriban_Workbench_Instructions",
                "Being an academy, Korriban ought to have a workbench just like Dantooine did. This mod adds one to the academy.",
                new Uri("https://deadlystream.com/files/file/375-korriban-academy-workbench/")
                ),
            new Mod(
                "Diversified Wounded Republic Soldiers",
                "DarthParametric",
                Immersion,
                Optional,
                new string[] { "[K1]_Diversified_Wounded_Republic_Soldiers_On_Taris_v1.3.7z" },
                "Diversified_Wounded_Republic_Soldiers_Instructions",
                "The wounded soldiers on Taris all use the same head model. This mod adds diversity by giving each a different head.",
                new Uri("https://deadlystream.com/files/file/1179-diversified-wounded-republic-soldiers-on-taris/")
                ),
            new Mod(
                "Diversified Jedi Captives",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2.7z", "[K1]_Diversified_Jedi_Captives_on_the_SF_JC_TSL_Robes_Compatibility_Patch.7z" },
                "Diversified_Jedi_Captives_Instructions",
                "Like the wounded soldiers, all of Malak’s Jedi captives on the Star Forge all use the same head. Furthermore, Malak says the PC should recognize from Dantooine (even though they didn’t appear there.). This mod gives each captive a unique appearance and includes an option to include them on Dantooine.",
                new Uri("https://deadlystream.com/files/file/1199-diversified-jedi-captives-on-the-star-forge/")
                ),
            new Mod(
                "Jedi Diversity",
                "DarthParametric",
                Immersion,
                Optional,
                new string[] { "[K1]_Jedi_Diversity_On_The_Star_Forge.7z" },
                "Jedi_Diversity_Instructions",
                "Diversifies the Jedi NPCs on the Star Forge using assets ported from SWTOR.",
                new Uri("https://deadlystream.com/files/file/1964-jedi-diversity-on-the-star-forge/")
                ),
            new Mod(
                "Dodonna's Transmission",
                "danil-ch",
                Immersion,
                Recommended,
                new string[] { "[K1]_Dodonna's_Transmission_v1.1.rar" },
                "Dodonnas_Transmission_Instructions",
                "During Dodonna’s LS transmission, the player is absent. This mod restores the player to the scene.",
                new Uri("https://deadlystream.com/files/file/1101-dodonna%E2%80%99s-transmission/")
                ),
            new Mod(
                "Party on the Leviathan",
                "Fair Strides",
                Restored,
                Optional,
                new string[] { "Leviathan Party.7z" },
                "Party_on_the_Leviathan_Instructions",
                "Apparently Juhani had some dialogue on the Leviathan that was cut for PCs. This mod restores it.",
                new Uri("https://deadlystream.com/files/file/567-party-on-the-leviathan/")
                ),
            new Mod(
                "Ported Alien Voiceovers",
                "Ashton Scorpius",
                Immersion,
                Recommended,
                new string[] { "K1 PAVOR v1.3.1.7z" },
                "Ported_Alien_Voiceovers_Instructions",
                "In vanilla several aliens shred VOs (like Nikto and Twi’lek). In KOTOR 2, these aliens had their own unique VOs. This mod ports the VOs from KOTOR 2 so each alien now has their own.",
                new Uri("https://deadlystream.com/files/file/1426-k1-ported-alien-vo-replacements/")
                ),
            new Mod(
                "Iriaz Restoration",
                "Cerez",
                Restored,
                Optional,
                new string[] { "iriaz.zip" },
                "Iriaz_Restoration_Instructions",
                "Iriaz were originally supposed to be on Dantooine but were cut. This mod restores them to add a little more life to the planet.",
                new Uri("https://deadlystream.com/files/file/1354-iriaz-on-dantooine/")
                ),
            new Mod(
                "Republic Mod Armor Reskin",
                "PirateOfRohan",
                Immersion,
                Optional,
                new string[] { "Republic Mod Armor Reskin.zip" },
                "Republic_Mod_Armor_Reskin_Instructions",
                "Reskins the Republic Mod Armor to be slightly more lore friendly.",
                new Uri("https://deadlystream.com/files/file/1906-republic-mod-armor-reskin/")
                ),
            new Mod(
                "Rescaled Trandoshans",
                "DarthParametric",
                Immersion,
                Optional,
                new string[] { "[K1]_Trandoshans_Rescale.7z" },
                "Rescaled_Trandoshans_Instructions",
                "Rescales the game’s Trandoshans so they are as tall as Wookies as described in Star Wars canon.",
                new Uri("https://deadlystream.com/files/file/947-trandoshans-rescaled-for-k1/")
                ),
            new Mod(
                "Czerka Overhaul",
                "garm343",
                Immersion,
                Recommended,
                new string[] { "Czerka Armor and Appearance Fix 1.4.zip" },
                "Czerka_Overhaul_Instructions",
                "The Czerka uniforms in KOTOR 1 were pretty bland and all the officers used the same uniform. Some didn’t even wear them at all (mostly aliens). This mod adds a tiered system of uniforms and armor based on ranking and gives aliens proper uniforms. Some of the armor is even obtainable in-game.",
                new Uri("https://deadlystream.com/files/file/1999-revised-czerka-armor-and-appearance-fix/")
                ),
            new Mod(
                "Cantina Song",
                "ebmar",
                Immersion,
                Optional,
                new string[] { "[K1]_Song_for_the_Cantina_v1.0.3.7z" },
                "Cantina_Song_Instructions",
                "The ambience in the cantinas were bland in vanilla. This mod grants Javyar’s Cantina a tune to spice it up a little.",
                new Uri("https://deadlystream.com/files/file/1294-k1-song-for-the-cantina/")
                ),
            new Mod(
                "Animated Swoop Monitors",
                "ebmar",
                Immersion,
                Optional,
                new string[] { "[K1]_Animated_Swoop_Screen_[TSLPort].7z" },
                "Animated_Swoop_Monitors_Instructions",
                "Animates the swoop monitors on Tatooine.",
                new Uri("https://deadlystream.com/files/file/1398-k1-animated-swoop-screen-tslport/")
                ),
            new Mod(
                "Bandon Reskin",
                "Silveredge9",
                Graphics,
                Optional,
                new string[] { "darth_bandon_head_reskin.rar" },
                "Bandon_Reskin_Instructions",
                "Reskins Bandon’s head to make him look more dark-sided, and it does it very nicely.",
                new Uri("https://www.gamefront.com/games/knights-of-the-old-republic/file/darth-bandon-head-reskin")
                ),
            new Mod(
                "Holocron Icon Replacement",
                "InSidious",
                Immersion,
                Optional,
                new string[] { "DI_HIR_20.7z" },
                "Holocron_Icon_Replacement_Instructions",
                "When you find Bastila’s holocron on Tatooine, and Lashowe’s on Korriban, you’ll find their icons look nothing like holocrons. This mod fixes the problem by giving both their own unique icons.",
                new Uri("https://deadlystream.com/files/file/149-holocron-icon-replacement/")
                ),
            new Mod(
                "Custom Selkath Animation",
                "Alvar007",
                Immersion,
                Optional,
                new string[] { "Custom Selkath Animation.rar" },
                "Custom_Selkath_Animation_Instructions",
                "The Selkath had an unused animation slot. This mod fills the slot by giving them a unique animation",
                new Uri("https://deadlystream.com/files/file/1555-custom-selkath-animation/")
                ),
            new Mod(
                "Elder Droid Unique VO",
                "ebmar",
                Immersion,
                Recommended,
                new string[] { "[K1]_Legends_-_Elder_Droids_Unique_VO_v1.0.0.7z" },
                "Elder_Droid_Unique_VO_Instructions",
                "The droid in the elder compound on Lehon uses the generic droid VO in vanilla. This mod gives it a unique VO similar to the Elder Rakata.",
                new Uri("https://deadlystream.com/files/file/1531-k1-legends-elder-droids-unique-vo/")
                ),
            new Mod(
                "Movie Style Endgame Holograms",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Movie-Style_Holograms_for_End_Game_Cutscenes_v1.1.7z" },
                "Movie_Style_Endgame_Holograms_Instructions",
                "Ever bothered by the fact that KOTOR 1’s holograms look nothing like KOTOR 2’s? This mod replaces the vanilla greenish holograms with movie-style ones more in line with KOTOR 2.",
                new Uri("https://deadlystream.com/files/file/1342-movie-style-holograms-for-end-game-cutscenes/")
                ),
            new Mod(
                "Movie Style Rakatan Holograms",
                "DarthParametric",
                Immersion,
                Recommended,
                new string[] { "[K1]_Movie-Style_Rakatan_Holograms_v1.2.1.7z" },
                "Movie_Style_Rakatan_Holograms_Instructions",
                "An addition to the previous mod which changes the Rakatan holograms.",
                new Uri("https://deadlystream.com/files/file/1346-movie-style-rakatan-holograms/")
                ),
            new Mod(
                "Movie Style Holograms for Twisted Rancor Trio",
                "DarthParametric",
                Immersion,
                Optional,
                new string[] { "[K1]_Movie-Style_Holograms_For_Twisted_Rancor_Trio_Puzzle.7z" },
                "Movie_Style_Holograms_for_Twisted_Rancor_Trio_Instructions",
                "Alters the holograms for the Twisted Rancor Trio puzzle to be movie-style as well as restores some dialogue to the puzzle.",
                new Uri("https://deadlystream.com/files/file/1736-movie-style-holograms-for-twisted-rancor-trio-puzzle/")
                ),
            new Mod(
                "Sunry Murder Recording Enhancement",
                "Fallen Guardian",
                Immersion,
                Optional,
                new string[] { "SMRE Version 3.0.zip" },
                "Sunry_Murder_Recording_Enhancement_Instructions",
                "During Sunry’s murder investigation, you likely came across the incriminating evidence in the Republic embassy. However, it never actually showed him committing the crime. This mod provides an actual recording of him committing the act.",
                new Uri("https://deadlystream.com/files/file/324-sunry-murder-recording-enhancement/")
                ),
            new Mod(
                "Dantooine Training Sabers",
                "Kexikus",
                Immersion,
                Optional,
                new string[] { "DanTrainingLS.zip" },
                "Dantooine_Training_Sabers_Instructions",
                "Replaces the swords seen during the Dantooine training sequence with training sabers.",
                new Uri("https://deadlystream.com/files/file/704-dantooine-training-lightsabers/")
                ),
            new Mod(
                "NPC Alignment Fix",
                "TK-664",
                Gameplay,
                Optional,
                new string[] { "NPC_Alignment_Fix_v1_1.rar" },
                "NPC_Alignment_Fix_Instructions",
                "Several NPCs don’t have proper alignments (e.g. many Dark Jedi are neutral). This mod adjusts the alignment of several NPCs so they make more sense.",
                new Uri("https://deadlystream.com/files/file/1866-npc-alignment-fix/")
                ),
            new Mod(
                "High Quality Skyboxes",
                "Kexikus",
                Graphics,
                Recommended,
                new string[] { "HQSkyboxesII_K1.7z" },
                "High_Quality_Skyboxes_Instructions",
                "Overhauls nearly every skybox in the game with a higher-resolution version.",
                new Uri("https://deadlystream.com/files/file/723-high-quality-skyboxes-ii/")
                ),
            new Mod(
                "High Quality Starfields",
                "Kexikus",
                Graphics,
                Recommended,
                new string[] { "K1_HDStarsAndNebulas_1_3.zip" },
                "High_Quality_Starfields_Instructions",
                "Replaces the default starfields with higher resolution versions.",
                new Uri("https://deadlystream.com/files/file/491-kotor-high-quality-starfields-and-nebulas/")
                ),
            new Mod(
                "High Quality Cockpit Skyboxes",
                "Sithspecter",
                Graphics,
                Recommended,
                new string[] { "High Quality Cockpit Skyboxes XL.zip" },
                "High_Quality_Cockpit_Skyboxes_Instructions",
                "Improves the Ebon Hawk’s skyboxes with higher resolution versions",
                new Uri("https://deadlystream.com/files/file/938-high-quality-cockpit-skyboxes/")
                ),
            new Mod(
                "High Poly Grenades",
                "MadDerp",
                Graphics,
                Optional,
                new string[] { "hp_grenades-0-4-1209-0-4-1547556830.zip" },
                "High_Poly_Grenades_Instructions",
                "The vanilla grenades are so low-poly they look like deflated spheroids. This mod increases their poly count they actually look like grenades.",
                new Uri("https://www.nexusmods.com/kotor/mods/1209")
                ),
            new Mod(
                "High Quality Blasters",
                "Sithspecter",
                Graphics,
                Recommended,
                new string[] { "High Quality Blasters 1.1.zip" },
                "High_Quality_Blasters_Instructions",
                "Substantially improves the quality of the blasters in-game.",
                new Uri("https://deadlystream.com/files/file/861-high-quality-blasters/")
                ),
            new Mod(
                "HD Gaffi Sticks",
                "Kexikus",
                Graphics,
                Optional,
                new string[] { "Gaffi Stick Improvement.zip" },
                "HD_Gaffi_Sticks_Instructions",
                "Improves the textures for the gaffi sticks with a unique texture for the chieftain.",
                new Uri("https://deadlystream.com/files/file/312-gaffi-stick-improvement/")
                ),
            new Mod(
                "New Grass",
                "MadDerp",
                Graphics,
                Optional,
                new string[] { "grass_HD-1207-0-7.zip" },
                "New_Grass_Instructions",
                "Improves grass and background textures on Taris, Kashyyyk. Dantooine & Manaan",
                new Uri("https://www.nexusmods.com/kotor/mods/1207")
                ),
            new Mod(
                "VP's High Poly Lightsabers",
                "Fallen Guardian",
                Graphics,
                Recommended,
                new string[] { "VP&#39;s Hi Poly Tin Cans - KotOR 1 1.1.zip" },
                "VPs_High_Poly_Lightsabers_Instructions",
                "Improves the models of lightsabers by increasing their poly count.",
                new Uri("https://deadlystream.com/files/file/299-vps-hi-poly-tin-cans-kotor-1/")
                ),
            new Mod(
                "Alternate Lightsaber Textures",
                "DarthParametric",
                Graphics,
                Recommended,
                new string[] { "[K1]_Alternative_Textures_for_VP's_Tin_Cans.7z" },
                "Alternate_Lightsaber_Textures_Instructions",
                "Provides textures for the VP's High Poly Lightsabers mod.",
                new Uri("https://deadlystream.com/files/file/1957-alternative-textures-for-vps-tin-cans/")
                ),
            new Mod(
                "JC's Lightsaber Visual Effects",
                "JCarter426",
                Graphics,
                Recommended,
                new string[] { "JC's Lightsaber Visual Effects for K1 v1.2.zip" },
                "JCs_Lightsaber_Visual_Effects_Instructions",
                "Improves the lightsaber visual effects in-game using effects created by tools that people who work on the Star Wars movies use.",
                new Uri("https://deadlystream.com/files/file/1316-jcs-lightsaber-visual-effects-for-k1/")
                ),
            new Mod(
                "JC's Blaster Visual Effects",
                "JCarter426",
                Graphics,
                Optional,
                new string[] { "JC's Blaster Visual Effects for K1.zip" },
                "JCs_Blaster_Visual_Effects_Instructions",
                "Improves the quality of the blaster bolts in-game.",
                new Uri("https://deadlystream.com/files/file/1271-jcs-blaster-visual-effects-for-k1/")
                ),
            new Mod(
                "HD Darth Malak",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Malak.rar", "N_DarthMalak01.tga" },
                "HD_Darth_Malak_Instructions",
                "Impressively improves the quality of Darth Malak.",
                new Uri("https://deadlystream.com/files/file/980-hd-darth-malak/")
                ),
            new Mod(
                "Better Male Twi'lek Heads",
                "Ashton Scorpius",
                Graphics,
                Recommended,
                new string[] { "K1 Twilek Heads v1.3.2.7z" },
                "Better_Male_Twilek_Heads_Instructions",
                "The male Twi’leks in KOTOR have terrible painted-on ears. This mod gives them geometrical ears using assets from TOR.",
                new Uri("https://deadlystream.com/files/file/1430-k1-better-twilek-male-heads/")
                ),
            new Mod(
                "High Resolution Beam Effects",
                "InSidious",
                Graphics,
                Optional,
                new string[] { "DI_HRBM_2.7z" },
                "High_Resolution_Beam_Effects_Instructions",
                "Improves the resolution of the beam effects in game (lightning, drain life, death field).",
                new Uri("https://deadlystream.com/files/file/260-k1-hi-res-beam-effects/")
                ),
            new Mod(
                "HD Fire & Ice",
                "Cinder Skye",
                Graphics,
                Optional,
                new string[] { "FireandIceHDWhee.zip" },
                "HD_Fire_And_Ice_Instructions",
                "Replaces fire and ice effects from grenades with HD ones.",
                new Uri("https://deadlystream.com/files/file/455-hd-fire-and-ice-whee/")
                ),
            new Mod(
                "K2 Green Crystal",
                "N-DReW25",
                UI,
                Optional,
                new string[] { "Green Crystal K2 to K1.zip" },
                "K2_Green_Crystal_Instructions",
                "KOTOR 2’s green crystal is much better than 1’s and it is reused as the viridian icon. This mod ports the icon from K2 for consistency.",
                new Uri("https://deadlystream.com/files/file/1283-green-crystal-from-k2-to-k1/")
                ),
            new Mod(
                "Alternate Stasis Icon",
                "StellarExile",
                UI,
                Optional,
                new string[] { "Stasis Icon.zip" },
                "Alternate_Stasis_Icon_Instructions",
                "Apparently there was supposed to be another stasis icon in the game. In my opinion, this one much better matches the progression of the icons and may have even been the originally intended one.",
                new Uri("https://deadlystream.com/files/file/2000-alternate-stasis-icon/")
                ),
            new Mod(
                "HD Twi'lek Female",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "hd_twilek_female.rar" },
                "HD_Twilek_Female_Instructions",
                "Dramatically improves the textures for Twi’lek females.",
                new Uri("https://deadlystream.com/files/file/982-hd-twilek-female/")
                ),
            new Mod(
                "HD Hutts",
                "Emperor Turnip",
                Graphics,
                Optional,
                new string[] { "Emperor Turnip&#39;s HD Hutts.rar" },
                "HD_Hutts_Instructions",
                "Improves the textures for Hutts.",
                new Uri("https://deadlystream.com/files/file/1188-emperor-turnips-hd-hutts/")
                ),
            new Mod(
                "HD Gizka",
                "Emperor Turnip",
                Graphics,
                Optional,
                new string[] { "Emperor Turnip&#39;s Gizka.rar" },
                "HD_Gizka_Instructions",
                "Improves the textures for Gizka.",
                new Uri("https://deadlystream.com/files/file/1190-emperor-turnips-hd-gizka/")
                ),
            new Mod(
                "HD Ships",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "hd_kt_400_military_droid_carrier_and_lethisk_class_armed_freighter.rar" },
                "HD_Ships_Instructions",
                "Improves the resolution of several ships.",
                new Uri("https://deadlystream.com/files/file/1125-hd-kt-400-military-droid-carrier-and-lethisk-class-armed-freighter/")
                ),
            new Mod(
                "Star Map Revamp",
                "CarthOnasty",
                Graphics,
                Recommended,
                new string[] { "Star-Map_Revamp_1-1.zip" },
                "Star_Map_Revamp_Instructions",
                "Improves the textures of the Rakatan Star Maps.",
                new Uri("https://deadlystream.com/files/file/1262-star-map-revamp/")
                ),
            new Mod(
                "HD Calo Nord",
                "Emperor Turnip",
                Graphics,
                Optional,
                new string[] { "HD Calo Nord by Emperor Turnip.rar" },
                "HD_Calo_Nord_Instructions",
                "Improves the quality of Calo Nord.",
                new Uri("https://deadlystream.com/files/file/1198-hd-calo-nord-by-emperor-turnip/")
                ),
            new Mod(
                "HD Wookies",
                "Curtis1973",
                Graphics,
                Optional,
                new string[] { "Wookie Pack High Resolution-1136-Final.zip" },
                "HD_Wookies_Instructions",
                "Improves the resolution of the Wookie textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1136")
                ),
            new Mod(
                "HD Gammoreans",
                "Quanon",
                Graphics,
                Recommended,
                new string[] { "Quanon_Gammoreans.rar" },
                "HD_Gammoreans_Instructions",
                "Retextures Gammoreans to much higher resolution with added detail.",
                new Uri("https://deadlystream.com/files/file/1023-quanons-gammorean-reskin-pack/")
                ),
            new Mod(
                "HD Mission Vao and Patch",
                "Quanon & Dark Hope",
                Graphics,
                Recommended,
                new string[] { "MissionHD.rar", "P_MissionH01.txi" },
                "HD_Mission_Vao_and_Patch_Instructions",
                "Drastically improves the quality of Mission.",
                new Uri("https://deadlystream.com/files/file/956-mission-vao-hd-by-quanon/"),
                "Patch found here: https://drive.google.com/file/d/1KD3ZZ3TACKEBs1wrw03omi9s28S57ET_/view"
                ),
            new Mod(
                "HD Canderous Ordo and Patch",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Canderous Ordo.rar", "P_CandBB01.txi" },
                "HD_Canderous_Ordo_and_Patch_Instructions",
                "Drastically improves the quality of Canderous.",
                new Uri("https://deadlystream.com/files/file/1123-hd-canderous-ordo/"),
                "Patch found here: https://drive.google.com/file/d/1O5H8Dkpp_Gz_-4qCuDqALXzogPkZ3QOI/view"
                ),
            new Mod(
                "HD Zaalbar",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "ZaalbarHD.rar" },
                "HD_Zaalbar_Instructions",
                "Improves the texture of Zaalbar.",
                new Uri("https://deadlystream.com/files/file/2031-zaalbar-hd/")
                ),
            new Mod(
                "Jolee Bindo HD",
                "Quanon",
                Graphics,
                Recommended,
                new string[] { "Quanons Jolee Reskin 1.1.rar" },
                "Jolee_Bindo_HD_Instructions",
                "Improves the textures for Jolee.",
                new Uri("https://deadlystream.com/files/file/1113-quanons-jolee-reskin/")
                ),
            new Mod(
                "HD Carth Onasi",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Carth Onasi.rar" },
                "Carth_Onasi_Instructions",
                "Improves the quality of Carth",
                new Uri("https://deadlystream.com/files/file/1133-hd-carth-onasi/")
                ),
            new Mod(
                "HD Bastila Shan",
                "Dark Hope & Quanon",
                Graphics,
                Recommended,
                new string[] { "Bastila HD.rar" },
                "HD_Bastila_Shan_Instructions",
                "Improves the quality of Bastila.",
                new Uri("https://deadlystream.com/files/file/978-bastila-shan-hd-by-quanon-and-dark-hopa/")
                ),
            new Mod(
                "Juhani Real Cathar Head",
                "miro42",
                Immersion,
                Recommended,
                new string[] { "juhaniCathar_head.zip" },
                "Juhani_Real_Cathar_Head_Instructions",
                "Juhani looks nothing like a Cathar should, at least according to the comics. This mod edits her model and texture so she actually looks like one.",
                new Uri("https://deadlystream.com/files/file/702-juhani-real-cathar-head/")
                ),
            new Mod(
                "Quanon's HK-47",
                "Quanon",
                Graphics,
                Recommended,
                new string[] { "Quanons_HK47_Reskin.rar" },
                "Quanons_HK47_Instructions",
                "Drastically improves the skin of HK-47.",
                new Uri("https://deadlystream.com/files/file/1001-quanons-hk-47-reskin/")
                ),
            new Mod(
                "HD Yuthura Ban",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Yuthura Ban.rar" },
                "HD_Yuthura_Ban_Instructions",
                "Improves the quality of Yuthura’s textures.",
                new Uri("https://deadlystream.com/files/file/1054-hd-yuthura-ban/")
                ),
            new Mod(
                "HD Pazaak Cards",
                "CarthOnasty",
                Graphics,
                Optional,
                new string[] { "HD_Pazaak_Cards.zip" },
                "HD_Pazaak_Cards_Instructions",
                "Improves the quality of Pazaak cards in the game.",
                new Uri("https://deadlystream.com/files/file/1361-hd-pazaak-cards/")
                ),
            new Mod(
                "HD Scoundrel Uniform",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "scoundrel.rar" },
                "HD_Scoundrel_Uniform_Instructions",
                "Improves the quality of the default clothing for the scoundrel.",
                new Uri("https://deadlystream.com/files/file/1479-k1-scoundrel-uniform-hd-international-global-mod/")
                ),
            new Mod(
                "HD Scout Uniform",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "[K1] Scout uniform HD International Global mod.rar" },
                "HD_Scout_Uniform_Instructions",
                "Improves the quality of the default clothing for the scout.",
                new Uri("https://deadlystream.com/files/file/1382-k1-scout-uniform-hd-international-global-mod/")
                ),
            new Mod(
                "Republic Soldier's New Shade",
                "ebmar",
                Graphics,
                Recommended,
                new string[] { "[K1]_Republic_Soldier's_New_Shade_v1.1.1.7z" },
                "Republic_Soldiers_New_Shade_Instructions",
                "Gives the Republic soldier uniform some shine on the trim and helmet.",
                new Uri("https://deadlystream.com/files/file/1365-k1-republic-soldiers-new-shade/")
                ),
            new Mod(
                "PFHA01 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHA01 HD.rar" },
                "PFHA01_HD_Instructions",
                "Drastically improves the quality of the player head PFHA01.",
                new Uri("https://deadlystream.com/files/file/1739-pfha01-hd/")
                ),
            new Mod(
                "PFHA02 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHA02 HD.rar" },
                "PFHA02_HD_Instructions",
                "Drastically improves the quality of the player head PFHA02.",
                new Uri("https://deadlystream.com/files/file/1737-pfha02-hd/")
                ),
            new Mod(
                "PFHA03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHA03 HD.rar" },
                "PFHA03_HD_Instructions",
                "Drastically improves the quality of the player head PFHA03.",
                new Uri("https://deadlystream.com/files/file/1749-pfha03-hd/")
                ),
            new Mod(
                "PFHA04 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHA04 HD.rar" },
                "PFHA04_HD_Instructions",
                "Drastically improves the quality of the player head PFHA04.",
                new Uri("https://deadlystream.com/files/file/1753-pfha04-hd/")
                ),
            new Mod(
                "PFHA05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "HD PFHA05.rar" },
                "PFHA05_HD_Instructions",
                "Drastically improves the quality of the player head PFHA05.",
                new Uri("https://deadlystream.com/files/file/1800-hd-pfha05/")
                ),
            new Mod(
                "PFHB01 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHB01 HD.rar" },
                "PFHB01_HD_Instructions",
                "Drastically improves the quality of the player head PFHB01.",
                new Uri("https://deadlystream.com/files/file/1735-pfhb01-hd/")
                ),
            new Mod(
                "PFHB02 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHB02 HD.rar" },
                "PFHB02_HD_Instructions",
                "Drastically improves the quality of the player head PFHB02.",
                new Uri("https://deadlystream.com/files/file/1752-pfhb02-hd/")
                ),
            new Mod(
                "PFHB03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "HD PFHB03.rar" },
                "PFHB03_HD_Instructions",
                "Drastically improves the quality of the player head PFHB03.",
                new Uri("https://deadlystream.com/files/file/1799-hd-pfhb03/")
                ),
            new Mod(
                "PFHB04 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHB04 HD.rar" },
                "PFHB04_HD_Instructions",
                "Drastically improves the quality of the player head PFHB04.",
                new Uri("https://deadlystream.com/files/file/1755-pfhb04-hd/")
                ),
            new Mod(
                "PFHB05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHB05HD.rar" },
                "PFHB05_HD_Instructions",
                "Drastically improves the quality of the player head PFHB05 HD",
                new Uri("https://deadlystream.com/files/file/1725-pfhb05-hd/")
                ),
            new Mod(
                "PFHC02 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHC02 HD.rar" },
                "PFHC02_HD_Instructions",
                "Drastically improves the quality of the player head PFHC02.",
                new Uri("https://deadlystream.com/files/file/1740-pfhc02-hd/")
                ),
            new Mod(
                "PFHC03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHC03.rar" },
                "PFHC03_HD_Instructions",
                "Drastically improves the quality of the player head PFHC03.",
                new Uri("https://deadlystream.com/files/file/1784-pfhc03-hd/")
                ),
            new Mod(
                "PFHC05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PFHC05 HD.rar" },
                "PFHC05_HD_Instructions",
                "Drastically improves the quality of the player head PFHC05.",
                new Uri("https://deadlystream.com/files/file/1738-pfhc05-hd/")
                ),
            new Mod(
                "PMHAO1 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHA01 HD.rar" },
                "PMHAO1_HD_Instructions",
                "Drastically improves the quality of the player head PMHAO1.",
                new Uri("https://deadlystream.com/files/file/1837-pmha01-hd/")
                ),
            new Mod(
                "PMHA02 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHA02 HD.rar" },
                "PMA02_HD_Instructions",
                "Drastically improves the quality of the player head PMHA02.",
                new Uri("https://deadlystream.com/files/file/1843-pmha02-hd/")
                ),
            new Mod(
                "PMHA03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHA03 HD.rar" },
                "PMHA03_HD_Instructions",
                "Drastically improves the quality of the player head PMHA03.",
                new Uri("https://deadlystream.com/files/file/983-pmha03-hd/")
                ),
            new Mod(
                "PMHA04 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHA04 HD.rar" },
                "PMHA04_HD_Instructions",
                "Drastically improves the quality of the player head PMHA04.",
                new Uri("https://deadlystream.com/files/file/1852-pmha04-hd/")
                ),
            new Mod(
                "PMHA05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHA05 HD.rar" },
                "PMHA05_HD_Instructions",
                "Drastically improves the quality of the player head PMHA05.",
                new Uri("https://deadlystream.com/files/file/1857-pmha05-hd/")
                ),
            new Mod(
                "PMHB01 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHB01 HD.rar" },
                "PMHB01_HD_Instructions",
                "Drastically improves the quality of the player head PMHB01.",
                new Uri("https://deadlystream.com/files/file/1826-pmhb01-hd/")
                ),
            new Mod(
                "PMHB03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHB03 HD.rar" },
                "PMHB03_HD_Instructions",
                "Drastically improves the quality of the player head PMHB03.",
                new Uri("https://deadlystream.com/files/file/1836-pmhb03-hd/")
                ),
            new Mod(
                "PMHB04 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHB04 HD.rar" },
                "PMHB04_HD_Instructions",
                "Drastically improves the quality of the player head PMHB04.",
                new Uri("https://deadlystream.com/files/file/1858-pmhb04-hd/")
                ),
            new Mod(
                "PMHB05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHB05 HD.rar" },
                "PMHB05_HD_Instructions",
                "Drastically improves the quality of the player head PMHB05.",
                new Uri("https://deadlystream.com/files/file/1828-pmhb05-hd/")
                ),
            new Mod(
                "PMHC01 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHC01 HD.rar" },
                "PMHC01_HD_Instructions",
                "Drastically improves the quality of the player head PMHC01.",
                new Uri("https://deadlystream.com/files/file/979-pmhc01-hd/")
                ),
            new Mod(
                "PMHC02 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHC02 HD.rar" },
                "PMHC02_HD_Instructions",
                "Drastically improves the quality of the player head PMHC02.",
                new Uri("https://deadlystream.com/files/file/1825-pmhc02-hd/")
                ),
            new Mod(
                "PMHC03 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHC03 HD.rar" },
                "PMHC03_HD_Instructions",
                "Drastically improves the quality of the player head PMHC03.",
                new Uri("https://deadlystream.com/files/file/1832-pmhc03-hd/")
                ),
            new Mod(
                "PMHC04 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHC04 HD.rar" },
                "PMHC04_HD_Instructions",
                "Drastically improves the quality of the player head PMHC04.",
                new Uri("https://deadlystream.com/files/file/1859-pmhc04-hd/")
                ),
            new Mod(
                "PMHC05 HD",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "PMHC05 HD.rar" },
                "PMHC05_HD_Instructions",
                "Drastically improves the quality of the player head PMHC05.",
                new Uri("https://deadlystream.com/files/file/1841-pmhc05-hd/")
                ),
            new Mod(
                "HD Men's Underwear",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Men's underwear HD.rar" },
                "HD_Mens_Underwear_Instructions",
                "Drastically improves the quality of the undergarments for male PCs.",
                new Uri("https://deadlystream.com/files/file/1874-mens-underwear-hd/")
                ),
            new Mod(
                "HD Women's Underwear",
                "Dark Hope",
                Graphics,
                Recommended,
                new string[] { "Women underwear.rar" },
                "HD_Womens_Underwear_Instructions",
                "Drastically improves the quality of the undergarments for female PCs.",
                new Uri("https://deadlystream.com/files/file/1794-women-underwear/")
                ),
            new Mod(
                "Vanilla Masks Overhaul",
                "xander2077",
                Graphics,
                Recommended,
                new string[] { "KoToR Vanilla Masks Overhaul.7z" },
                "Vanilla_Masks_Overhaul_Instructions",
                "All the vanilla masks have decent textures but are pretty low-resolution. This mod replaces each with a higher-resolution version and it does a wonderful job of it.",
                new Uri("https://deadlystream.com/files/file/867-vanilla-masks-overhaul/"),
                "Download the 5.1 mb version"
                ),
            new Mod(
                "HD Taris and Patch",
                "ShiningRedHD, patch by StellarExile",
                Graphics,
                Recommended,
                new string[] { "Ultimate Taris High Resolution - TPC Version-1360-2-2-1613057746.rar", "LTS_lobwal03.zip" },
                "HD_Taris_and_Patch_Instructions",
                "Overhauls the planet of Taris with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1360"),
                "Download patch here: https://drive.google.com/file/d/1utSPMbZC8keFdClLzelJoC4qdRStNj3e/view"
                ),
            new Mod(
                "HD Manaan",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Manaan High Resolution - TGA Version-1366-1-0-1607345982.rar" },
                "HD_Manaan_Instructions",
                "Overhauls Manaan with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1366")
                ),
            new Mod(
                "HD Dantooine",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Dantooine High Resolution - TPC Version-1368-1-1-1607550040.rar" },
                "HD_Dantooine_Instructions",
                "Overhauls Dantooine with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1368")
                ),
            new Mod(
                "HD Kashyyyk",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Kashyyyk High Resolution - TPC Version-1365-1-1-1607596812.rar" },
                "HD_Kashyyyk_Instructions",
                "Overhauls Kashyyyk with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1365")
                ),
            new Mod(
                "HD Tatooine",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Tatooine High Resolution - TPC Version-1364-1-1-1607594654.rar" },
                "HD_Tatooine_Instructions",
                "Overhauls Tatooine with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1364")
                ),
            new Mod(
                "Old Republic Skin Overhaul",
                "multiple",
                Graphics,
                Recommended,
                new string[] { "Tatooine v1.0-68-1-0.7z" },
                "Old_Republic_Skin_Overhaul_Instructions",
                "A reskin for several areas in-game. However, we’ll only be using the one for Tatooine.",
                new Uri("https://www.nexusmods.com/kotor/mods/68")
                ),
            new Mod(
                "Lehon HD",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Unknown World High Resolution - TGA Version-1369-1-1-1613465520.rar" },
                "Lehon_HD_Instructions",
                "Overhauls Lehon with new HD textures.",
                new Uri("https://www.nexusmods.com/kotor/mods/1369")
                ),
            new Mod(
                "Korriban HD",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Korriban High Resolution - TPC Version-1367-1-1-1607600772.rar" },
                "Korriban_HD_Instructions",
                "Improves the textures for Korriban.",
                new Uri("https://www.nexusmods.com/kotor/mods/1367")
                ),
            new Mod(
                "HD Ships & Stations",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Endar Spire-Star Forgre-Yavin Station - TPC Version-1370-1-0-1607439060.rar" },
                "HD_Ships_And_Stations_Instructions",
                "Provides new HD textures for the Star Forge, Yavin station, and the Endar Spire.",
                new Uri("https://www.nexusmods.com/kotor/mods/1370")
                ),
            new Mod(
                "Placeables Specularity Tweaks",
                "ebmar",
                Graphics,
                Optional,
                new string[] { "[K1]_Placeables_Specularity_Tweaks_v0.1.0.7z" },
                "Placeables_Specularity_Tweaks_Instructions",
                "Adjusts the specularity of several placeables (footlockers, metal boxes etc.) to give them a shining effect.",
                new Uri("https://deadlystream.com/files/file/1359-k1-placeables-specularity-tweaks/")
                ),
            new Mod(
                "Animated Ebon Hawk Monitors",
                "Sith Holocron",
                Graphics,
                Optional,
                new string[] { "SH_EH_Animated_Monitors.7z" },
                "Animated_Ebon_Hawk_Monitors_Instructions",
                "Animates the monitors on the Ebon Hawk.",
                new Uri("https://deadlystream.com/files/file/848-animated-ebon-hawk-monitors-not-including-galaxy-map/")
                ),
            new Mod(
                "Ebon Hawk Repairs",
                "PapaZinos",
                Bug,
                Recommended,
                new string[] { "Ultimate_Ebon_Hawk_Repairs_For_K1_Animation_Fix_v1.0.2.7z" },
                "Ebon_Hawk_Repairs_Instructions",
                "The Ebon Hawk is chock full of lightmap issues and holes. This mod fixes as many as possible",
                new Uri("https://deadlystream.com/files/file/2036-ultimate-ebon-hawk-repairs-for-k1/?tab=reviews&sort=newest#review-6503")
                ),
            new Mod(
                "Ebon Hawk High Resolution",
                "Vurt",
                Graphics,
                Suggested,
                new string[] { "vurt_k1_eh_retexture_v10.rar" },
                "Ebon_Hawk_High_Resolution_Instructions",
                "Reskins the exterior of the Hawk to high resolution.",
                new Uri("https://www.gamefront.com/games/knights-of-the-old-republic/file/vurt-s-k1-hi-res-ebon-hawk-retexture")
                ),
            new Mod(
                "Character Overhaul",
                "ShiningRedHD",
                Graphics,
                Recommended,
                new string[] { "Ultimate Character Overhaul -REDUX- (FULL) - TGA Version-1282-4-1-1628534742.rar" },
                "Character_Overhaul_Instructions",
                "An HD upscale that improves nearly every character texture in the game. Note that we will not be using all the textures as some of them are used by other mods.",
                new Uri("https://www.nexusmods.com/kotor/mods/1282?tab=files")
                ),
            new Mod(
                "Character Overhaul Patches",
                "ShiningRedHD",
                Patch,
                Recommended,
                new string[] {
                    "JC's Minor Fixes - Compatibility Patch-1282-4-1-1629713341.rar",
                    "KOTOR 1 Community Patch - Compatibility Patch-1282-4-1-1629713397.rar",
                    "Republic Soldier's New Shade - Compatibility Patch-1282-4-1-1629713494.rar",
                    "Miscellaneous Compatibility Patches-1282-4-1-1629713437.rar"
                },
                "Character_Overhaul_Patches_Instructions",
                "Some compatibility patches for the character overhaul.",
                new Uri("https://www.nexusmods.com/kotor/mods/1282?tab=files")
                ),
            new Mod(
                "JC's Jedi Tailor",
                "JCarter426",
                Added,
                Recommended,
                new string[] { "JC's Jedi Tailor for K1 v1.4.zip" },
                "JCs_Jedi_Tailor_Instructions",
                "Were you ever annoyed that you couldn’t change the color of your Jedi robes? Well, now you can! This mod adds in a unique merchant on Dantooine capable of changing the color of Jedi robes for you and your party members.",
                new Uri("https://deadlystream.com/files/file/1477-jcs-jedi-tailor-for-k1/")
                ),
            new Mod(
                "Bendak Bounty Non Dark Side Option",
                "Thrak Farelle",
                Story,
                Recommended,
                new string[] { "tar02_duelorg021.dlg" },
                "Bendak_Bounty_Non_Dark_Side_Option_Instructions",
                "During Bendak’s bounty quest, the player would inevitably gain dark side points. This mod adds in an alternative route for LS players that allows them to fight Bendak to stop his slayings rather than for money.",
                new Uri("https://drive.google.com/file/d/1NuewBFq390wkZuBkbJzN-mN4sIRlvXGd/view")
                ),
        };
    }
}
