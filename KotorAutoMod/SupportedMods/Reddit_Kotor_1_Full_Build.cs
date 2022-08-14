using System;
using System.Collections.Generic;

namespace KotorAutoMod.SupportedMods
{
    internal static class Reddit_Kotor_1_Full_Build
    {
        // Importance
        const string Essential = "Essential";
        const string Recommended = "Recommended";
        const string Suggested = "Suggested";
        const string Optional = "Optional";

        // Types
        const string Bug = "Bug Fix";
        const string QoL = "QoL";
        const string Graphics = "Graphics Improvements";
        const string Gameplay = "Gameplay Improvements";
        const string Immersion = "Immersion";
        const string Restored = "Restored Content";
        const string Patch = "Patch";
        const string Added = "Added Content";
        const string Appearance = "Appearance Change";
        const string Mechanics = "Mechanics Change";

        public static List<Mod> supportedModsReddit = new List<Mod>
        {
            new Mod(
                "Quicker TSL Patching",
                "xypherh",
                new string[] { QoL },
                Essential,
                new string[] {"Script-1214-1-0.zip" },
                "Quicker_TSL_Patching_Instructions",
                "Creates a symlink to your swkotor folder for easier use of the TSLPatcher. (This is not a mod)",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1214") }
                ),
            new Mod(
                "KOTOR Dialouge Fixes",
                "Salk & Kainzorus Prime",
                new string[] { Immersion },
                Essential,
                new string[] { "KotOR_Dialogue_Fixes_4_0.zip" },
                "Reddit_KOTOR_Dialouge_Fixes_Instructions",
                "In addition to fixing several typos, this mod takes the PC's dialogue--which is written in such a way as to make the PC sound constantly shocked, stupid, or needlessly and overtly evil--and replaces it with more moderate and reasonable responses, even for DS choices.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1313-kotor-dialogue-fixes/") }
                ),
            new Mod(
                "Character Startup Changes",
                "jonathan7, patch by A Future Pilot",
                new string[] { Gameplay },
                Recommended,
                new string[] { "Character Start Up Changes.zip", "Character_Startup_Changes_Patch.rar" },
                "Reddit_Character_Startup_Changes_Instructions",
                "In a normal KOTOR start, your character's feats are pre-selected. This mod changes the initial level-up so that the number of feat points given is determined by class, but you can choose the feats you wish to invest into.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/349-character-start-up-change/"), new Uri("https://mega.nz/file/MFIByAKY#8MaLMEUvI-xMJ20buuugR8DTNHa6wab2RK3tk5kBMnk") }
                ),
            new Mod(
                "JC's Minor Fixes",
                "JCarter426",
                new string[] { Bug, Graphics },
                Recommended,
                new string[] { "JC's Minor Fixes for K1 v1.1.zip" },
                "Reddit_JCs_Minor_Fixes_Instructions",
                "KOTOR, like with any game, has a slew of little oversights, or things BioWare messed up by accident. The goal of this mod is to fix most of those small things not addressed in other, larger mods.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1333-jcs-minor-fixes-for-k1/") }
                ),
            new Mod(
                "Ultimate Character Overhaul",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Character Overhaul -REDUX- (FULL) - TGA Version-1282-4-1-1628534742.rar" },
                "Reddit_Character_Overhaul_Instructions",
                "Ultimate Character Overhaul is a comprehensive AI-upscale of every character and piece of equipment in the game. Unlike previous AI upscales, the Ultimate series has no transparency problems while still retaining reflections on character textures, all without any additional steps required. This is an incredibly high-quality mod, and ShiningRed has even gone through the trouble to make compatibility patches for the mod builds, upscaling some of the later textures we use!",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1282?tab=files") }
                ),
            new Mod(
                "Ajunta Pall Appearance",
                "Silveredge9, Patch by A Future Pilot",
                new string[] { Appearance, Graphics },
                Recommended,
                new string[] { "ajunta_pall_unique_appearance_1.1.rar", "Ajunta Pall Unique Appearance.zip" },
                "Reddit_Ajunta_Pall_Appearance_Instructions",
                "This mod reskins Ajunta Pall to have a unique appearance that matches the honorary statue in the tomb.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/824-ajunta-pall-unique-appearance/"), new Uri("https://mega.nz/file/McJF1AIC#Jywhu6zXWCRz4gRghxMxoBAWrbU_A3giD1INsOoHqmA") }
                ),
            new Mod(
                "KOTOR Community Patch",
                "Various Authors; Darth Parametric, JCarter426 & A Future Pilot Collate",
                new string[] { Bug, Graphics, Immersion },
                Essential,
                new string[] { "K1_Community_Patch_v1.9.2.zip" },
                "Reddit_Kotor_1_Community_Patch_Instructions",
                "An ambitious compilation intending to be a comprehensive bugfix mod for the original game, the KOTOR Community Patch combines hundreds of various fixes and improvements from over a dozen other mods, as well as fixes put together by AFP, DP and JC on their own. With bugfixes as important to KOTOR as TSLRCM's are to KOTOR 2, I can't recommend its use highly enough.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1258-kotor-1-community-patch/") }
                ),
            new Mod(
                "Specularity Tweaks",
                "ebmar",
                new string[] { Graphics },
                Suggested,
                new string[] { "[K1]_Placeables_Specularity_Tweaks_v0.1.0.7z" },
                "Reddit_Specularity_Tweaks_Instructions",
                "Alters the specularity of several placeable objects ingame to get the most out of the vanilla textures.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1359-k1-placeables-specularity-tweaks/") }
                ),
            new Mod(
                "Ultimate Korriban",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Korriban High Resolution - TPC Version-1367-1-1-1607600772.rar" },
                "Korriban_HD_Instructions",
                "In addition to fully upscaling all of the NPCs and equipment in the game, ShiningRed has also produced a series of mods using the same techniques that update all the planet textures. This mod upscales the Sith world of Korriban.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1367") }
                ),
            new Mod(
                "Ultimate Kashyyyk",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Kashyyyk High Resolution - TPC Version-1365-1-1-1607596812.rar" },
                "HD_Kashyyyk_Instructions",
                "This mod upscales the forest-world of Kashyyyk, home of the Wookiees.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1365") }
                ),
            new Mod(
                "Ultimate Tatooine",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Tatooine High Resolution - TPC Version-1364-1-1-1607594654.rar" },
                "HD_Tatooine_Instructions",
                "This mod upscales the iconic desert world Tatooine.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1364") }
                ),
            new Mod(
                "Ultimate Dantooine",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Dantooine High Resolution - TPC Version-1368-1-1-1607550040.rar" },
                "HD_Dantooine_Instructions",
                "This mod upscales the peaceful retreat of Dantooine.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1368") }
                ),
            new Mod(
                "Ultimate Endar Spire +",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Endar Spire-Star Forgre-Yavin Station - TPC Version-1370-1-0-1607439060.rar" },
                "HD_Ships_And_Stations_Instructions",
                "This mod is a compilation upscale which includes upscales for three different areas: the Endar Spire, the Star Forge, and Yavin Station.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1370") }
                ),
            new Mod(
                "Ultimate Manaan",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Manaan High Resolution - TGA Version-1366-1-0-1607345982.rar" },
                "HD_Manaan_Instructions",
                "This mod upscales the water-world Manaan.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1366") },
                "The TPC version is mislabeled as TGA, so make sure to download the TPC version"
                ),
            new Mod(
                "Ultimate Unknown World",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Unknown World High Resolution - TPC Version-1369-1-1-1-1642331603.rar" },
                "Reddit_Ultimate_Unknown_World_Instructions",
                "This mod upscales the mysterious Lehon.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1369") }
                ),
            new Mod(
                "Ultimate Taris",
                "ShiningRedHD",
                new string[] { Graphics },
                Essential,
                new string[] { "Ultimate Taris High Resolution - TGA Version-1360-2-2-1613057322.rar" },
                "Reddit_Ultimate_Taris_Instructions",
                "This mod upscales the sprawling world-city of Taris.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1360") }
                ),
            new Mod(
                "Duncan on Manaan",
                "Seamhainn",
                new string[] { Restored },
                Recommended,
                new string[] { "Duncan on Manaan.7z" },
                "Deadeye_Duncan_Restoration_Instructions",
                "This mod restores content which was left on the disk but was never implemented which would have let the player interact with Deadeye Duncan later on in the story, on Manaan.",
                new Uri[] { new Uri("https://mega.nz/file/IR4QASTa#V28cTdgcNTMPwPrNbMElbnNVHkqhkKu7vJgL7PWVZ0U") }
                ),
            new Mod(
                "HD Pazaak Cards",
                "CarthOnasty",
                new string[] { Graphics },
                Suggested,
                new string[] { "HD_Pazaak_Cards.zip" },
                "Reddit_HD_Pazaak_Cards_Instructions",
                "When you play space blackjack, you want the cards to at least look good, right?",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1361-hd-pazaak-cards/") }
                ),
            new Mod(
                "Scoundrel Trousers",
                "Darkbirdie",
                new string[] { Bug },
                Optional,
                new string[] { "Scoundrel Trousers.zip" },
                "Reddit_Scoundrel_Trousers_Instructions",
                "Fixes the trouser texture of the female scoundrel's default clothing. By default it's pulled in and up.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/537-scoundrel-trousers/") }
                ),
            new Mod(
                "Republic Soldier Fix",
                "JCarter426",
                new string[] { Graphics, Appearance },
                Recommended,
                new string[] { "JC's Republic Soldier Fix for K1 v1.3.zip" },
                "Reddit_Republic_Soldier_Fix_Instructions",
                "Fixes the low-resolution default female Republic soldier skin, as well as fixing issues with the male model and making the Republic uniform the default clothing for the Soldier-class character.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1180-jcs-republic-soldier-fix-for-k1/") }
                ),
            new Mod(
                "Republic Soldier's New Shade",
                "ebmar",
                new string[] { Graphics },
                Recommended,
                new string[] { "[K1]_Republic_Soldier's_New_Shade_v1.1.1.7z" },
                "Reddit_Republic_Soldiers_New_Shade_Instructions",
                "By default, despite being what looks like a mix of metallic and polymer elements, the Republic armor has no shine effect ingame. This mod fixes that so it's realistically reflective.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1365-k1-republic-soldiers-new-shade/") }
                ),
            new Mod(
                "HD PC Portraits",
                "ndix UR",
                new string[] { Graphics },
                Suggested,
                new string[] {"hd_npc_portraits-v2.0.7z" },
                "HD_NPC_Portraits_Instructions",
                "ndix strikes again with a wonderful upscale that takes all the default player character portraits and sharpens them without altering their appearance. This mod is great for keeping a unified sense of high graphical fidelity, especially when playing in widescreen.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1213-hd-npc-portraits/") }
                ),
            new Mod(
                "\"Mullet Man\" Retexture",
                "ZimmMaster",
                new string[] { Graphics },
                Recommended,
                new string[] { "Mullet Man Retexture.7z" },
                "Reddit_Mullet_Man_Retexture_Instructions",
                "This mod reskins and improves the resolution of the \"mullet man\" player head.",
                new Uri[] { new Uri("https://mega.nz/file/8UAUTJjJ#xE3MR4CVZ56M3mPM8NQF3ZrayxrZV0lHhDqGMBLbpFE") }
                ),
            new Mod(
                "PMHA05 HD",
                "Dark Hope",
                new string[] { Graphics, Appearance },
                Suggested,
                new string[] { "PMHA05 HD.rar" },
                "PMHA05_HD_Instructions",
                "This is the first in a series of high-resolution player heads from Dark Hope, complete with full Dark Side transitions and new player portraits. We aren't going to use all of the HD versions she made--I've been careful to only select those I think fit closely with the original player head, as well as making enough clear improvements that any aesthetic alterations are acceptable trade-offs for the improved texture quality.\n\nThis specific texture reskins the fifth Asian male head preset, including new facial hair.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1857-pmha05-hd/") }
                ),
            new Mod(
                "PMHA02 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "PMHA02 HD.rar" },
                "PMA02_HD_Instructions",
                "This Dark Hope retexture reskins the second Asian male head preset. It is mostly a straight graphics improvement, with minimal deviation from the default appearance.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1843-pmha02-hd/") }
                ),
            new Mod(
                "PMHAO1 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "PMHA01 HD.rar" },
                "PMHAO1_HD_Instructions",
                "This Dark Hope retexture reskins the first Asian male head preset. It is mostly a straight graphics improvement, but features a very minimalist DS transition.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1837-pmha01-hd/") }
                ),
            new Mod(
                "PMHB05 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "PMHB05 HD.rar" },
                "PMHB05_HD_Instructions",
                "This Dark Hope retexture reskins the fifth black male head preset. It is mostly a straight graphics improvement, but does alter the default skin tone and has a minimalist DS transition.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1828-pmhb05-hd/") }
                ),
            new Mod(
                "PMHB01 HD",
                "Dark Hope",
                new string[] { Graphics, Appearance },
                Suggested,
                new string[] { "PMHB01 HD.rar" },
                "PMHB01_HD_Instructions",
                "Alright I'm not going to be cutesy, this basically makes the first Black male head preset into 'Ye. Why, I'm not sure. But I actually really like the texture work on it.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1826-pmhb01-hd/") }
                ),
            new Mod(
                "PFHB03 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "HD PFHB03.rar" },
                "PFHB03_HD_Instructions",
                "This Dark Hope retexture reskins the third Asian female head preset. It is mostly a straight graphics improvement, but features a very minimalist DS transition.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1799-hd-pfhb03/") }
                ),
            new Mod(
                "PFHC05 HD",
                "Dark Hope",
                new string[] { Graphics, Appearance },
                Recommended,
                new string[] { "PFHC05 HD.rar" },
                "PFHC05_HD_Instructions",
                "This Dark Hope retexture reskins the fifth Caucasian female head preset. Dark Hope took some liberties here, adding a more detailed hair ornament and a tattoo to the side of the player's head, but I really enjoy the changes.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1738-pfhc05-hd/") }
                ),
            new Mod(
                "PFHB01 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "PFHB01 HD.rar" },
                "PFHB01_HD_Instructions",
                "This Dark Hope retexture reskins the first black female head preset. It is mostly a straight graphics improvement, but does feature a darker skin tone.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1735-pfhb01-hd/") }
                ),
            new Mod(
                "PFHB05 HD",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "PFHB05HD.rar" },
                "PFHB05_HD_Instructions",
                "This Dark Hope retexture reskins the fifth black female head preset. It is mostly a straight graphics improvement, but does feature a darker skin tone.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1725-pfhb05-hd/") }
                ),
            new Mod(
                "PFHB02 Eye Fix",
                "Darth Parametric",
                new string[] { Bug, Graphics },
                Recommended,
                new string[] { "[K1]_Player_Head_PFHB02_DS_Transition_Eye_Fix.7z" },
                "Reddit_PFHB02_Eye_Fix_Instructions",
                "The eye overlays on the second black female head were input incorrectly and become offset as the player transitions to the Dark Side, creating the appearance of duplicated irises. This mod fixes that, as well as offering an upscale option which improves the base appearance of the head.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1762-player-head-pfhb02-dark-side-transition-eye-fix/") }
                ),
            new Mod(
                "High-Poly Grenades",
                "MadDerp",
                new string[] { Graphics },
                Optional,
                new string[] { "hp_grenades-0-4-1209-0-4-1547556830.zip" },
                "High_Poly_Grenades_Instructions",
                "Fixes the models of the grenades to make them more spherical, and therefore ensure the basegame textures fit on them more accurately.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1209") }
                ),
            new Mod(
                "HD Gizka",
                "Emperor Turnip",
                new string[] { Graphics },
                Optional,
                new string[] { "Emperor Turnip&#39;s Gizka.rar" },
                "HD_Gizka_Instructions",
                "Improves the base texture of the Gizka creature.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1190-emperor-turnips-hd-gizka/") }
                ),
            new Mod(
                "HD Rakghouls",
                "Emperor Turnip",
                new string[] { Graphics },
                Suggested,
                new string[] { "Emperor Turnip&#39;s HD Rakghouls.rar" },
                "Reddit_HD_Rakghouls_Instructions",
                "Improves the base texture of the Rakghoul creature.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1187-emperor-turnips-hd-rakghouls/") }
                ),
            new Mod(
                "Gammorean Reskin Pack",
                "Quanon",
                new string[] { Graphics },
                Recommended,
                new string[] { "Quanon_Gammoreans.rar" },
                "HD_Gammoreans_Instructions",
                "Improves and upscales the textures of the game's Gammoreans.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1023-quanons-gammorean-reskin-pack/") }
                ),
            new Mod(
                "Better Twi'lek Heads",
                "Ashton Scorpius",
                new string[] { Graphics },
                Recommended,
                new string[] { "K1 Twilek Heads v1.3.2.7z" },
                "Reddit_Better_Twilek_Heads_Instructions",
                "Unlike female Twi'lek, male Twi'lek are supposed to have ears. Operative word: supposed to. Their ears are barely visible at all in KOTOR, which this mod fixes using TOR ear geometry.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1430-k1-better-twilek-male-heads/") }
                ),
            new Mod(
                "HD Twi'lek Female",
                "Dark Hope",
                new string[] { Graphics },
                Recommended,
                new string[] { "hd_twilek_female.rar" },
                "HD_Twilek_Female_Instructions",
                "Adds higher-resolution default clothing, lekku, faces and skin to female twi'lek in the game.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/982-hd-twilek-female/") }
                ),
            new Mod(
                "Thigh-High Boots for Twi'lek",
                "DarthParametric",
                new string[] { Graphics },
                Recommended,
                new string[] { "[K1]_Thigh-High_Boots_For_Twilek_Body_MODDERS_RESOURCE.7z" },
                "Reddit_Thigh_High_Boots_For_Twilek_Instructions",
                "In vanilla, female Twi'lek's thigh-high boots are painted on the character's texture rather than added to their equipped clothing as an item, which would give them realistic three-dimensional depth and higher resolution. This modder's resource serves to add the boots as an equipped object.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1087-k1-thigh-high-boots-for-female-twilek-body-modders-resource/") }
                ),
            new Mod(
                "Shaleena/Lashowe Mouth Fix",
                "Ashton Scorpius",
                new string[] { Bug },
                Suggested,
                new string[] { "K1 SL Mouth Adjustment v1.1.0.7z" },
                "Reddit_Shaleena_Lashowe_Mouth_Fix_Instructions",
                "Fixes a bug with two female NPC heads which caused their upper teeth to be invisible during dialogue.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1480-k1-shaleenalashowe-mouth-adjustment/") }
                ),
            new Mod(
                "Shaleena Head Restoration",
                "Stellar Exile",
                new string[] { Restored, Appearance },
                Suggested,
                new string[] { "Shaleena Head Restoration.zip" },
                "Shaleena_Original_Head_Restoration_Instructions",
                "Restores a cut unique appearance for the NPC Shaleena on Taris. The above mod by Ashton will also fix the teeth issue in this mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1896-shaleena-original-head-restoration/") }
                ),
            new Mod(
                "Calo Nord Recolor",
                "Watcher07",
                new string[] { Appearance },
                Suggested,
                new string[] { "Calo Nord Recolor.zip" },
                "Reddit_Calo_Nord_Recolor_Instructions",
                "Recolors Calo Nord's clothing to be more muted in tone; you wouldn't expect a famous bounty hunter to run around in bright colors, would you? Note that this does not allow you to play as Calo, nor does it add the custom blaster skin or republic uniform skin seen in the screenshots.",
                new Uri[] { new Uri("https://mega.nz/file/hJhGEbza#qemCHVzBcCWkL__n6mrmVNzD3P2qdV4MWEYQvJudtJY") }
                ),
            new Mod(
                "HD Darth Malak",
                "Dark Hope",
                new string[] { Graphics },
                Recommended,
                new string[] { "Malak.rar" },
                "Reddit_HD_Darth_Malak_Instructions",
                "Drastically improves the overall graphical quality of Malak. The screenshots really don't do this mod justice, it's excellent.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/980-hd-darth-malak/") }
                ),
            new Mod(
                "HD Vrook",
                "Dark Hope, edited by Publicola",
                new string[] { Graphics },
                Recommended,
                new string[] { "HD Vrook Recolored.zip" },
                "Reddit_HD_Vrook_Instructions",
                "Drastically improves the overall graphical quality of Vrook.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1962-hd-vrook-recolored/") }
                ),
            new Mod(
                "HD UI Elements",
                "Sdub",
                new string[] { Graphics },
                Suggested,
                new string[] { "Random HD UI Elements.zip" },
                "Reddit_HD_UI_Elements_Instructions",
                "Improves a few miscellaneous textures, including planet textures on the galaxy map and companion textures in the character selection screen. Many of the companion selection screen textures will be overwritten with custom ones from subsequent mods, but Sdub's variants are miles ahead of vanilla.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1909-random-hd-ui-elements/") }
                ),
            new Mod(
                "HD NPC Portraits",
                "ndix UR",
                new string[] { Graphics },
                Suggested,
                new string[] {"hd_npc_portraits-v2.0.7z" },
                "HD_NPC_Portraits_Instructions",
                "A companion to his PC portrait rework, HD NPC Portraits takes all the companion portraits and drastically improves their quality without modifying the underlying aesthetic.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1213-hd-npc-portraits/") }
                ),
            new Mod(
                "Bastila Shan HD",
                "Dark Hope",
                new string[] { Graphics },
                Recommended,
                new string[] { "Bastila Shan HD (clothing).rar" },
                "Reddit_Bastila_Shan_HD_Instructions",
                "Vastly improves the skin and default clothes textures of Bastila. Note that, for our purposes, we do not use this mod's changes to Bastila's head or face.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/978-bastila-shan-hd-by-quanon-and-dark-hopa/") }
                ),
            new Mod(
                "Party Model Fixes",
                "redrob41",
                new string[] { Bug },
                Recommended,
                new string[] { "K1 Party Model fixes and HD Bastila by RedRob41.7z" },
                "Reddit_Party_Model_Fixes_Instructions",
                "Several of the companion models are messed up in ways that you don't really notice until you begin slapping hi-res textures on them. Since we're going to get to that, this mod is pretty important as a prerequisite.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1273-party-model-fixes-and-hd-bastila/") }
                ),
            new Mod(
                "Juhani Appearance Overhaul",
                "Stormie97",
                new string[] { Appearance, Immersion, Graphics },
                Recommended,
                new string[] { "Juhani Appearance Overhaul.rar" },
                "Reddit_Juhani_Appearance_Overhaul_Instructions",
                "This mod is an all-in-one overhaul for Juhani, including a new body texture, new unique clothing, and a custom lightsaber for our favorite angry Cathar. Bear in mind we don't use this mod's changes to Juhani's head, instead relying on the below mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1669-juhani-appearance-overhaul/") }
                ),
            new Mod(
                "Juhani Cathar Head",
                "Miro42",
                new string[] { Appearance, Graphics },
                Recommended,
                new string[] { "juhaniCathar_head.zip" },
                "Juhani_Real_Cathar_Head_Instructions",
                "Juhani's head model has always been a disappointing reminder of the limitations of low resolution. This mod makes the best attempt of any I've seen so far to portray Juhani as truly Cathar, without going to extremes or failing to overcome the limitations of her original facial design.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/702-juhani-real-cathar-head/") }
                ),
            new Mod(
                "Korriban: Back in Black",
                "JCarter426",
                new string[] { Appearance, Bug },
                Recommended,
                new string[] { "JC's Korriban - Back in Black for K1 v2.3.zip" },
                "Reddit_JCs_Back_in_Black_Instructions",
                "Find it strange that all Sith at the Korriban academy are apparently officers and not Dark Jedi? This mod reskins all the Jedi in the Academy to wear proper robes, as well as fixing several other appearance issues on Korriban.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1293-jcs-korriban-back-in-black-for-k1/") }
                ),
            new Mod(
                "Cloaked Jedi Robes",
                "JCarter426",
                new string[] { Appearance },
                Recommended,
                new string[] { "JC's Fashion Line I - Cloaked Jedi Robes for K1 v1.4.7z" },
                "JCs_Cloaked_Robes_Instructions",
                "If you preferred the robes in KOTOR 2, as most seem to, does JC have a mod for you. Cloaked Jedi Robes migrates all of the robe types from KOTOR 2 straight into KOTOR, while still managing to retain the unique color schemes of the original (should you choose to use one of the two options for that, anyway!). If you've long sought robe consistency across the two games, look no further.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1378-jcs-fashion-line-i-cloaked-jedi-robes-for-k1/") }
                ),
            new Mod(
                "JC's Jedi Tailor",
                "JCarter426",
                new string[] { Immersion },
                Optional,
                new string[] { "JC's Jedi Tailor for K1 v1.4.zip" },
                "JCs_Jedi_Tailor_Instructions",
                "It's very annoying when you've got your party together and you want to show your swag off with color-coordinated outfits, but the game only gives you gaudy blue robes. Worry no longer! JC has given us a solution in the form of a skilled Trandoshan tailor, who will dye your robes on demand--it's also compatible with Cloaked Jedi Robes! He even has some very well-written and lore-friendly dialogue about current events.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1477-jcs-jedi-tailor-for-k1/") }
                ),
            new Mod(
                "Quanon's HK-47",
                "Quanon",
                new string[] { Graphics },
                Recommended,
                new string[] { "Quanons_HK47_Reskin.rar" },
                "Quanons_HK47_Instructions",
                "Improves the appearance of HK-47 by adding more detail, dimming the shine of his armor, and generally making his appearance in the first game more closely approximate a cleaner version of his appearance from KOTOR 2.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1001-quanons-hk-47-reskin/") }
                ),
            new Mod(
                "HD Astromech Droids",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "DrdAstro HD.rar" },
                "Reddit_HD_Astromech_Droids_Instructions",
                "Vastly improves the skin of not just T3-M4, but all astromech droids in the game. Also includes party and companion portraits.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1894-astromech-droid-hd/") }
                ),
            new Mod(
                "HD Carth Onasi",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "Carth Onasi (new clothes).rar" },
                "Reddit_HD_Carth_Onasi_Instructions",
                "Vastly improves the skin and default clothes textures of Carth. Note that, for our purposes, we do not use this mod's changes to Carth's head or face.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1133-hd-carth-onasi/") }
                ),
            new Mod(
                "HD Canderous Ordo and Patch",
                "Dark Hope",
                new string[] { Graphics },
                Recommended,
                new string[] { "Canderous Ordo.rar", "Canderous Patch.rar" },
                "Reddit_HD_Canderous_Ordo_and_Patch_Instructions",
                "Vastly improves the skin and default clothes textures of Canderous. Note that, for our purposes, we do not use this mod's changes to Canderous's head or face; we use the head textures of the following mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1123-hd-canderous-ordo/"), new Uri("https://mega.nz/file/dFJBEYhA#FY9h6AmYVDizyVPZo_I3vXqAIWVrK1TUzT42msGqtpQ") }
                ),
            new Mod(
                "Quanon's Canderous",
                "Quanon",
                new string[] { Graphics },
                Recommended,
                new string[] { "Quanon_CandOrdo_Reskin.rar" },
                "Reddit_Quanons_Canderous_Instructions",
                "Vastly improves the head and face texture of Canderous. Note that, for our purposes, we do not use this mod's changes to Canderous's body or clothes; we use those textures from the previous mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/941-quanons-canderous-ordo-reskin/") }
                ),
            new Mod(
                "Fen's Jolee",
                "Fenharel",
                new string[] { Graphics },
                Recommended,
                new string[] { "Fen's - Jolee-1192-1.zip" },
                "Reddit_Fens_Jolee_Instructions",
                "Do your best to ignore the lighting of the screenshots. This mod actually looks very good, at least for its head textures. That's all we'll be using it for.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1192") }
                ),
            new Mod(
                "Zaalbar HD",
                "corpsecotillion",
                new string[] { Graphics },
                Suggested,
                new string[] { "bigz.rar" },
                "Reddit_Zaalbar_HD_Instructions",
                "An improvement of Zaalbar's default texture, especially his hair and coloration.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1074-zaalbar-hd/") }
                ),
            new Mod(
                "Stylized Portraits",
                "/u/Tinman888",
                new string[] { Appearance },
                Optional,
                new string[] { "Stylized Portraits by Tinman888.zip" },
                "Reddit_Stylized_Portraits_Instructions",
                "Presented as an alternative to the other HD companion portrait mods previously listed, as well as those companion pictures modified by some of the above graphics mods. If you prefer a more stylized look to your party selection wheel, this lovely mod is the pick for you. Bear in mind that the Revan portrait is optional, so you can exclude that if you would prefer to keep the PC's portraits vanilla.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1929-stylized-portraits-by-tinman888/") }
                ),
            new Mod(
                "Star Map Revamp",
                "CarthOnasty",
                new string[] { Graphics },
                Suggested,
                new string[] { "Star-Map_Revamp_1-1.zip" },
                "Star_Map_Revamp_Instructions",
                "Reskins the Star Maps to a new HD texture, with similar improvements to the map of the galaxy the star maps display.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1262-star-map-revamp/") }
                ),
            new Mod(
                "Background Improvements",
                "Dark Hope",
                new string[] { Graphics },
                Suggested,
                new string[] { "hd_kt_400_military_droid_carrier_and_lethisk_class_armed_freighter.rar" },
                "HD_Ships_Instructions",
                "Reskins some of the ships seen in the background of the game. By default their appearances are awful, because the players were never meant to look too closely at them.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1125-hd-kt-400-military-droid-carrier-and-lethisk-class-armed-freighter/") }
                ),
            new Mod(
                "Hi-Res Ebon Hawk",
                "Vurt",
                new string[] { Graphics },
                Recommended,
                new string[] { "vurt_k1_eh_retexture_v10.rar" },
                "Ebon_Hawk_High_Resolution_Instructions",
                "Reskins the vessel the Ebon Hawk to extreme high resolution.",
                new Uri[] { new Uri("https://www.gamefront.com/games/knights-of-the-old-republic/file/vurt-s-k1-hi-res-ebon-hawk-retexture") }
                ),
            new Mod(
                "HQ Cockpit Skyboxes",
                "Sithspecter",
                new string[] { Graphics },
                Suggested,
                new string[] { "High Quality Cockpit Skyboxes XL.zip" },
                "High_Quality_Cockpit_Skyboxes_Instructions",
                "Vastly improves the quality of exterior areas as seen from the cockpit of the Ebon Hawk.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/938-high-quality-cockpit-skyboxes/") }
                ),
            new Mod(
                "Taris Reskin",
                "Quanon",
                new string[] { Graphics },
                Recommended,
                new string[] { "Taris_Reskin-10-1-0.zip" },
                "Reddit_Taris_Reskin_Instructions",
                "Reskins the streets of Taris to resemble a more realistically grimy, run-down appearance. Also gives certain locations (like Davik's estate) a more grandiose, elegant appearance.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/10/") }
                ),
            new Mod(
                "High Quality Starfields",
                "Kexikus",
                new string[] { Graphics },
                Suggested,
                new string[] { "K1_HDStarsAndNebulas_1_3.zip" },
                "High_Quality_Starfields_Instructions",
                "Upscales and beautifies the various starfields encountered throughout the game.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/491-kotor-high-quality-starfields-and-nebulas/") }
                ),
            new Mod(
                "HQ Skyboxes II",
                "Kexikus",
                new string[] { Graphics },
                Recommended,
                new string[] { "HQSkyboxesII_K1.7z" },
                "High_Quality_Skyboxes_Instructions",
                "Massively improves and increases the resolution of all skyboxes for all planets in the game.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/723-high-quality-skyboxes-ii/") }
                ),
            new Mod(
                "High Resolution Beam Effects",
                "InSidious",
                new string[] { Graphics },
                Recommended,
                new string[] { "DI_HRBM_2.7z" },
                "High_Resolution_Beam_Effects_Instructions",
                "An ambitious effect replacer for most \"beam\" style attacks in the game. Don't let the still screenshots fool you, this is an extremely well-made mod that looks excellent compared to the original textures when in-game.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/260-k1-hi-res-beam-effects/") }
                ),
            new Mod(
                "HD Fire & Ice",
                "Cinder Skye",
                new string[] { Graphics },
                Recommended,
                new string[] { "FireandIceHDWhee.zip" },
                "HD_Fire_And_Ice_Instructions",
                "Makes further improvements to the fire and ice textures above and beyond those included in the above mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/455-hd-fire-and-ice-whee/") }
                ),
            new Mod(
                "Animated Cantina Sign",
                "Sith Holocron",
                new string[] { Graphics },
                Suggested,
                new string[] { "SH_AnimatedCantinaSign.7z" },
                "Reddit_Animated_Cantina_Sign_Instructions",
                "Animates some cantina signs which were previously stationary.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1129-animated-cantina-sign-for-kotor-1/") }
                ),
            new Mod(
                "Animated Swoop Monitors",
                "ebmar",
                new string[] { Immersion },
                Suggested,
                new string[] { "[K1]_Animated_Swoop_Screen_[TSLPort].7z" },
                "Animated_Swoop_Monitors_Instructions",
                "Replaces the static swoop racing viewscreens with animated versions, for your immersive benefit.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1398-k1-animated-swoop-screen-tslport/") }
                ),
            new Mod(
                "Loadscreens in Color",
                "Sithspecter",
                new string[] { Appearance, Immersion },
                Suggested,
                new string[] { "Loadscreens in Color.zip" },
                "Reddit_Loadscreens_in_Color_Instructions",
                "Colorizes the previously blue-grey loadscreens of the game, to add a bit of life to module changes.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/916-loadscreens-in-color/") }
                ),
            new Mod(
                "Reflective Lightsaber Blades",
                "Crazy34",
                new string[] { Appearance, Immersion, Graphics },
                Essential,
                new string[] { "New_Lightsaber_Blades_K1_v_1.rar" },
                "Reddit_Reflective_Lightsaber_Blades_Instructions",
                "With this mod, Crazy34 walked into the community, slammed down one of the most impressive mods ever made for this game, and dared us to do better. Not only have they split the blade texture in two to allow for lightsabers with cores of a different color (currently unsupported in the build release, but hopefully coming soon), they've also added dynamic reflections to each and every lightsaber across every area of the game. When you're fighting a Dark Jedi, you're going to see your faces bathed in shifting colors, fading and brightening as you swing your lightsabers; when you ignite your saber in a hallway, it will reflect on the floor and walls, and will realistically increase in intensity as the blade draws nearer to the surface. This is an incredible project, and easily one of the most important--and impressive--mods ever released for KOTOR. In the next few years, it could completely change the face of lightsaber modding.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1846-new_lightsaber_blade_model_k1/") }
                ),
            new Mod(
                "Blaster Visual Effects",
                "JCarter426",
                new string[] { Graphics },
                Suggested,
                new string[] { "JC's Blaster Visual Effects for K1.zip" },
                "Reddit_Blaster_Visual_Effects_Instructions",
                "Sharpens the color and texture of blaster bolts fired in the game.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1271-jcs-blaster-visual-effects-for-k1/") }
                ),
            new Mod(
                "Wookiee Warblade Fix",
                "RedRob",
                new string[] { Bug },
                Suggested,
                new string[] { "WookieWarbladeFix-Redrob41.7z" },
                "Reddit_Wookiee_Warblade_Fix_Instructions",
                "A reuploaded variant of an older fix by RedRob, this mod elongates the handle of the Wookiee Warblade weapon so that the player no longer tries to grip it directly with their hands.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1899-wookie-warblade-fix/") }
                ),
            new Mod(
                "Kill The Czerka Guard",
                "TamerBill",
                new string[] { Added },
                Suggested,
                new string[] { "KillCzerkaJerk.zip" },
                "Reddit_Kill_The_Czerka_Guard_Instructions",
                "If you're feeling a bit sociopathic, this mod lets you kill a particularly rude Czerka employee on Kashyyyk.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1856-request-kill-the-czerka-jerk-on-kashyyyk/") }
                ),
            new Mod(
                "Korriban Workbench",
                "InSidious",
                new string[] { Added },
                Suggested,
                new string[] { "di_kaw2.7z" },
                "Korriban_Workbench_Instructions",
                "By default, there's no workbench on Korriban, which can result in some tedious back-and-forth between planets if you want to switch out crystals or upgrade some armor. This mod fixes that.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/375-korriban-academy-workbench/") }
                ),
            new Mod(
                "Sharina Fizark Restoration",
                "Sekan",
                new string[] { Restored },
                Suggested,
                new string[] { "sharina_fizark_restoration_1.1.zip"},
                "Reddit_Sharina_Fizark_Restoration_Instructions",
                "If you remember the woman on Tatooine who offers to sell you her dead husband's Wraid plate, this mod restores a later appearance by her on Dantooine, should you have helped her.",
                new Uri[] { new Uri("https://www.gamefront.com/games/knights-of-the-old-republic/file/sharina-fizark-restoration-1") }
                ),
            new Mod(
                "Senni Vek Restoration",
                "N-DReW25",
                new string[] { Restored },
                Optional,
                new string[] { "Senni Vek Restoration.zip" },
                "Senni_Vek_Restoration_Instructions",
                "Restores the initial character who leads you to the Geno'Haradan as one of Hulas's henchmen for the showdown on Tatooine.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1090-senni-vek-restoration/") }
                ),
            new Mod(
                "Hidden Bek Control Room",
                "N-DReW25",
                new string[] { Restored },
                Optional,
                new string[] { "Bek Control Room Restoration 1.1.zip" },
                "Hidden_Bek_Control_Room_Instructions",
                "The annoying locked door in the Hidden Bek base was, it turns out, probably not intentionally locked in the first place. This mod restores the player's ability to access it, if you turn on Gadon.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/908-hidden-bek-control-room-restoration/") }
                ),
            new Mod(
                "Vision Enhancement",
                "JCarter426",
                new string[] { Appearance },
                Recommended,
                new string[] { "JC's Vision Enhancement for K1 v1.2.zip" },
                "JCs_Vision_Enhancement_Instructions",
                "Some of the visions which the player is meant to have of the past and the Star Maps have some issues, both of location and of the player's strange decision to wear armor to bed. This mod fixes that.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1402-jcs-vision-enhancement-for-k1/") }
                ),
            new Mod(
                "New Leviathan Dialogue",
                "Revanator",
                new string[] { Added, Immersion },
                Suggested,
                new string[] { "Leviathan Differentiated Dialogue.7z" },
                "Leviathan_Differentiated_Dialogue_Instructions",
                "Gives different companions different dialogue choices when speaking to the Rodian prisoner on board the Leviathan.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/895-leviathan-differentiated-dialogue/") }
                ),
            new Mod(
                "Balanced Pazaak",
                "A Future Pilot",
                new string[] { Mechanics },
                Suggested,
                new string[] { "Balanced Pazaak.zip" },
                "Balanced_Pazaak_Instructions",
                "Pazaak players in the original KOTOR cheat, badly. While there's no way to prevent the computer from favoring NPCs in draws, there is a way to drastically reduce their ability to help themselves, and that's to give them all decks one tier lower than what their difficulty says they should have.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1270-balanced-pazaak/") }
                ),
            new Mod(
                "Camera Replacement",
                "LDR",
                new string[] { Mechanics },
                Essential,
                new string[] { "ebon_hawk_camera.zip" },
                "Ebon_Hawk_Camera_Replacement_Instructions",
                "By default, the camera angle inside the Ebon Hawk is ridiculously close to the PC, which not only makes the PC take up the majority of the screen, it also makes it very hard to see around you. This mod replaces the Ebon Hawk camera angle with one closer to the camera angles present in the rest of the game, and similar to KOTOR 2's Ebon Hawk camera angle.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/827-ebon-hawk-camera-replacement/") }
                ),
            new Mod(
                "Improved Grenades",
                "jc2",
                new string[] { Mechanics },
                Suggested,
                new string[] { "Improved Grenades.7z" },
                "Improved_Grenades_Instructions",
                "In the base-game, grenades typically aren't very useful after the first few planets, once Force powers and the PC's combat capabilities begin to spin up. This mod seeks not only to increase the value of grenades throughout the game but to also make the enemies wielding them more dangerous by tying the total damage output of a grenade to the demolitions stat of the thrower.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1191-improved-grenades/") }
                ),
            new Mod(
                "Turret Minigame Remover",
                "KittyKitty",
                new string[] { Mechanics },
                Suggested,
                new string[] { "NO_Fighters.zip-90-v1-0.zip" },
                "Reddit_Turret_Minigame_Remover_Instructions",
                "It's annoying at best to have to worry about potentially fighting Sith fighters before every hyperspace jump, especially when the fighting isn't particularly difficult and you don't gain anything for winning. This mod removes all such sequences, only leaving the scripted fighter engagements in place.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/90") }
                ),
            new Mod(
                "Repeater Attacks Restoration",
                "R2-X2",
                new string[] { Mechanics, Bug },
                Essential,
                new string[] { "Repeating blaster attacks restoration.zip" },
                "Reddit_Repeater_Attacks_Restoration_Instructions",
                "Blasters in the original KOTOR are underpowered all-around, but out of the entire laughingstock none is worse than blaster repeaters, which cost more in return for equivalent damage and less crit chance. It turns out that these weapons were originally supposed to have two attack rounds, but BioWare didn't have the time or know-how to implement this before the game went gold. This mod restores this function, with only a few instances where it doesn't work due to hardcoded scripting.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1405-repeating-blaster-attacks-restoration/") }
                ),
            new Mod(
                "Tutorial Remover",
                "Darthbdaman",
                new string[] { Mechanics, Immersion },
                Optional,
                new string[] { "Tutorial Remover-1171-1-4-1-1654916692.7z" },
                "Reddit_Tutorial_Remover_Instructions",
                "If you're on your second playthrough, Trask, his annoying pauses to explain things you already know, and all the \"press the A button!\" dialogue doesn't just take you out of the experience, it's infuriating. This mod removes Trask entirely, and therefore all of the immersion-breaking dialogue that comes with him. It's just you fighting your way to Carth.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1171") }
                ),
            new Mod(
                "Saber Throw Knockdown",
                "uwadmin12",
                new string[] { Mechanics },
                Recommended,
                new string[] { "saberthrow_kd.zip" },
                "Saber_Throw_Knockdown_Instructions",
                "By default, the \"Throw Lightsaber\" power is a little weak. Not only does it seem like it takes forever, it does much less damage in a much smaller AoE than powers like Lightning--or even Wave! The goal of this mod is giving Advanced Throw Lightsaber some additional functionality that makes using it worthwhile, namely the inclusion of a knockdown effect on the primary target if that target fails to pass a saving throw. This can make the ability useful for screening particular zones while also dealing damage--still somewhat less effective than Wave, but with more guaranteed damage.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1487-k1-saber-throw-knockdown-effect/") }
                ),
            new Mod(
                "Sunry Enhancement",
                "FallenGuardian",
                new string[] { Added, Immersion },
                Recommended,
                new string[] { "SMRE Version 3.0.zip" },
                "Sunry_Murder_Recording_Enhancement_Instructions",
                "Rather than having Sunry only verbally explain what happened when he murdered the Sith officer on Manaan, there's now a recording that goes along with the dialogue that shows what happened.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/324-sunry-murder-recording-enhancement/") }
                ),
            new Mod(
                "Recruit T3-M4 Early",
                "brents742",
                new string[] { Restored },
                Suggested,
                new string[] { "RecruitT3M4Early.rar" },
                "Reddit_Recruit_T3M4_Early_Instructions",
                "This mod restores the option to buy T3-M4 from Janice Nall as soon as you have the cash to do so. Dialogue was present in the files indicating that this was always meant to have been an option, but for some reason was scrapped from the final release. You can now buy T3 as soon as you're ready and use him until you unlock Mission, Zalbaar, and your other party members.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1868-recruit-t3-m4-early/") }
                ),
            new Mod(
                "Security Spikes for K1",
                "JCarter426",
                new string[] { Bug },
                Recommended,
                new string[] { "JC's Security Spikes for K1 v1.2.zip" },
                "JCs_Security_Spikes_Instructions",
                "In all BioWare's infinite brilliance, when they ported KOTOR to PC they didn't just cap the menus to 800x600, they also broke security spikes so they're literally unusable. This mod can't fix that, but it can give you a workaround: either some hacky functionality that works just like spikes do, or cold, hard cash in the places where spikes would normally drop.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1439-jcs-security-spikes-for-k1/") }
                ),
            new Mod(
                "High Quality Blasters",
                "Sithspecter",
                new string[] { Graphics },
                Essential,
                new string[] { "High Quality Blasters 1.1.zip" },
                "Reddit_High_Quality_Blasters_Instructions",
                "Massively improves the appearance of almost all blaster weapons in-game without altering their original design.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/861-high-quality-blasters/") }
                ),
            new Mod(
                "Crashed Republic Cruiser",
                "LDR",
                new string[] { Added, Immersion },
                Recommended,
                new string[] { "ldr_repshipunknownworld.zip" },
                "Crashed_Republic_Cruiser_Instructions",
                "It's difficult for me to talk about this mod without gushing about it. In my opinion, this mod is the best piece of added quest content ever made for either KOTOR or KOTOR 2: best-written, best-structured, best-balanced, best-voiced, and most sensible. It brings the player's past into the equation without mandating anything about their nature, and provides a real and immersive look at what your character's past was, and future could be, all while being lore-friendly to BOTH KOTOR 2 and The Old Republic. The only reason this mod isn't marked as Essential is because it reuses one module in a way which doesn't allow for suspension of disbelief--everything else about this mod is perfect.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1878-a-crashed-republic-cruiser-on-a-nameless-world/") }
                ),
            new Mod(
                "Trandoshans Rescaled",
                "DarthParametric",
                new string[] { Immersion },
                Optional,
                new string[] { "[K1]_Trandoshans_Rescale.7z" },
                "Rescaled_Trandoshans_Instructions",
                "Canonically Trandoshans are huge, as tall as Wookiees. This mod rescales them to stand about as high.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/947-trandoshans-rescaled-for-k1/") }
                ),
            new Mod(
                "Custom Selkath Animation",
                "Alvar007",
                new string[] { Bug },
                Suggested,
                new string[] { "Custom Selkath Animation.rar" },
                "Custom_Selkath_Animation_Instructions",
                "At many points in the files the Selkath are called on to make an \"angry\" animation type, but BioWare never made one for them. This is a custom animation for the Selkath that allow them to react properly whenever the files call for an angry emote.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1555-custom-selkath-animation/") }
                ),
            new Mod(
                "Sneak Attack Restoration",
                "N-DReW25",
                new string[] { Mechanics },
                Recommended,
                new string[] { "Sneak Attack 10 Restoration.zip" },
                "Sneak_Attack_X_Restoration_Instructions",
                "Stealth builds already don't get enough love in KOTOR, so the restoration of Sneak Attack 10 is helpful for anyone wanting to try an alternate build. This significantly increases the damage of sneak attacks for Mission and a Scoundrel player when they reach level 19.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1124-sneak-attack-10-restoration/") }
                ),
            new Mod(
                "Sherruk with Lightsabers",
                "Shem, patch by A Future Pilot & Darth Parametric",
                new string[] { Immersion },
                Suggested,
                new string[] { "sherruksabers.7z", "SAWL Patch.rar" },
                "Reddit_Sherruk_With_Lightsabers_Instructions",
                "Sherruk, the Mandalorian leader on Dantooine, likes to collect the lightsabers of the Jedi whom he's killed, and the settlers on the plains tell you that he's been heard to use them in battle. With this mod he really does use those lightsabers--and an impressively expanded inventory of equipment--to fuck your shit up.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/693-sherruk-attacks-with-lightsabers/"), new Uri("https://mega.nz/file/QNImBQSb#OPon0ZYbakcZpxZKMxSp559ezQWFU-wNXJ7Sj3ERBg4") }
                ),
            new Mod(
                "Helena Shan Improvement",
                "VarsityPuppet",
                new string[] { Appearance },
                Recommended,
                new string[] { "Helena_Shan_Improvement.zip" },
                "Helena_Shan_Improvement_Instructions",
                "This mod changes Helana Shan's appearance to more closely resemble that of her daughter Bastila, while also improving on her texture.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1218-helena-shan-improvement/") }
                ),
            new Mod(
                "Bastila's Dark Bodysuit",
                "Revanator",
                new string[] { Appearance, Immersion },
                Recommended,
                new string[] { "Bastila's Dark Bodysuit TSLPatcher 1Step.zip" },
                "Reddit_Bastilas_Dark_Bodysuit_Instructions",
                "As much as I'd like to think that Malak is just too lazy to care, it's unlikely he'd let Bastila run around with the same pseudo-robes she used as a Jedi without marking her as subservient to the Dark Side. This mod adds a new, slick dark-themed version of Bastila's clothing which she receives for the temple mount encounter and beyond.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1006-bastilas-dark-bodysuit-by-quanon-revanator/") }
                ),
            new Mod(
                "Dueling Arena Adjustment",
                "DarthParametric",
                new string[] { Appearance, Bug, Graphics },
                Recommended,
                new string[] { "[K1]_Taris_Dueling_Arena_Adjustment_v1.3.7z" },
                "Taris_Dueling_Arena_Adjustments_Instructions",
                "The \"crowd\" in the Taris Dueling Arena is, by default, just a few sprites stuffed in the background. They look awful, and I bet they looked awful even in 2003. Blessedly, this mod fixes that by switching the sprites out with a much more dense crowd, as well as fixing other miscellaneous issues with the arena.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1404-taris-dueling-arena-adjustment/") }
                ),
            new Mod(
                "Bendak Non-Darkside Option",
                "Thrak Farelle, edited by A Future Pilot",
                new string[] { Immersion },
                Suggested,
                new string[] { "tar02_duelorg021.dlg" },
                "Bendak_Bounty_Non_Dark_Side_Option_Instructions",
                "Since Selven can be killed as a government contract with no DS points gained, why can't Bendak? This mod allows the player to decide whether they're agreeing to the death match just because they want blood (DS) or because they simply want to ensure Bendak doesn't kill anyone else (LS).",
                new Uri[] { new Uri("https://drive.google.com/file/d/1NuewBFq390wkZuBkbJzN-mN4sIRlvXGd/view") }
                ),
            new Mod(
                "Kashyyyk Forcefield Rework",
                "DarthParametric",
                new string[] { Immersion },
                Recommended,
                new string[] { "[K1]_Control_Panel_For_Kashyyyk_Shadowlands_Forcefield_v1.1.7z" },
                "Kashyyyk_Control_Panel_Instructions",
                "By default, the forcefield in the Kashyyyk shadowlands doesn't have any point of interaction to it, and so to get around this oversight BioWare had to use some camera trickery to prevent the player from seeing what Jolee was doing. This mod fixes this, as well as some other issues with the area, allowing the area transition to work with a more normal camera angle.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1427-control-panel-for-kashyyyk-shadowlands-forcefield/") }
                ),
            new Mod(
                "Engine Lab Bench",
                "DarthParametric",
                new string[] { Bug },
                Suggested,
                new string[] { "[K1]_Black_Vulkar_Base_Engine_Lab_Bench_For_Swoop_Accelerator.7z" },
                "Vulkar_Lab_Bench_Instructions",
                "Moves a bench out of the way of combat while sitting a highly valuable piece of hardware on it instead of, y'know, the floor. Helps with pathing issues.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1747-black-vulkar-base-engine-lab-bench-for-swoop-accelerator/") }
                ),
            new Mod(
                "Missing Lamps Fix",
                "Ebmar",
                new string[] { Bug },
                Optional,
                new string[] { "[K1]_UWTMF_Missing_Lamps_Fix_v1.0.0.7z" },
                "Reddit_Missing_Lamps_Fix_Instructions",
                "Several lamps which are supposed to be visible had bad references assigned to them, which caused them to fail spawning in and led to phantom light sources. This mod fixes that, as well as fixing the positioning of a misaligned pillar in the same area.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1545-k1-temple-main-floor-missing-lamps-fix/") }
                ),
            new Mod(
                "Sith Texture Restoration",
                "A Future Pilot",
                new string[] { Restored },
                Suggested,
                new string[] { "Sith Soldier Texture Restoration-v2.4.zip" },
                "Sith_Soldier_Texture_Restoration_Instructions",
                "It turns out there were several textures planned for Sith Troopers that didn't make it fully into the game. This mod restores an alternate white texture which was meant for Elite troopers, who by default simply share the appearance of regular troopers.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1289-sith-soldier-texture-restoration/") }
                ),
            new Mod(
                "Diversified Republic Soldiers",
                "DarthParametric",
                new string[] { Appearance },
                Suggested,
                new string[] { "[K1]_Diversified_Wounded_Republic_Soldiers_On_Taris_v1.3.7z" },
                "Reddit_Diversified_Wounded_Republic_Soldiers_Instructions",
                "By default, the Republic soldiers in Zelka Forn's clinic on Taris all have the exact same model. This mod varies their appearance to preserve realism.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1179-diversified-wounded-republic-soldiers-on-taris/") }
                ),
            new Mod(
                "Diversified Jedi Captives",
                "DarthParametric",
                new string[] { Appearance },
                Recommended,
                new string[] { "[K1]_Diversified_Jedi_Captives_on_the_SF_v1.2.2.7z" },
                "Reddit_Diversified_Jedi_Captives_Instructions",
                "This mod ensures all the Jedi captives on the Star Forge don't use the same model, and are instead realistically unique in appearance.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1199-diversified-jedi-captives-on-the-star-forge/") }
                ),
            new Mod(
                "Dodonna's Transmission",
                "danil-ch",
                new string[] { Immersion },
                Recommended,
                new string[] { "[K1]_Dodonna's_Transmission_v1.1.rar" },
                "Dodonnas_Transmission_Instructions",
                "When just about to assault the Star Forge, Admiral Dodonna contacts the Ebon Hawk. Inexplicably, in the DS version of the cutscene the player is present, but in the LS version, despite the player's incredible importance, they're entirely absent. This mod adds the player into the LS version of the scene as well, so they match up.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1101-dodonna%E2%80%99s-transmission/") }
                ),
            new Mod(
                "Endgame Hologram Fix",
                "DarthParametric",
                new string[] { Appearance },
                Recommended,
                new string[] { "[K1]_Movie-Style_Holograms_for_End_Game_Cutscenes_v1.1.7z" },
                "Movie_Style_Endgame_Holograms_Instructions",
                "Gets rid of the ugly, \"painted\" holograms used for Dodonna's transmission sequence and replaces them with variants closer to the movies, and KOTOR 2.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1342-movie-style-holograms-for-end-game-cutscenes/") }
                ),
            new Mod(
                "Twisted Rancor Trio Fix",
                "DarthParametric",
                new string[] { Appearance },
                Recommended,
                new string[] { "[K1]_Movie-Style_Holograms_For_Twisted_Rancor_Trio_Puzzle.7z" },
                "Movie_Style_Holograms_for_Twisted_Rancor_Trio_Instructions",
                "Replaces the holograms for the Twisted Rancor Trio puzzle on Taris with variants closer to those seen in the movies, and KOTOR 2.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1736-movie-style-holograms-for-twisted-rancor-trio-puzzle/") }
                ),
            new Mod(
                "Rakatan Hologram Fix",
                "DarthParametric",
                new string[] { Appearance },
                Recommended,
                new string[] { "[K1]_Movie-Style_Rakatan_Holograms_v1.2.1.7z" },
                "Movie_Style_Rakatan_Holograms_Instructions",
                "Replaces the Rakatan Elder holograms with variants closer to those seen in the movies, and KOTOR 2.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1346-movie-style-rakatan-holograms/") }
                ),
            new Mod(
                "Elder Droid Unique VO",
                "ebmar",
                new string[] { Immersion },
                Optional,
                new string[] { "[K1]_Legends_-_Elder_Droids_Unique_VO_v1.0.0.7z" },
                "Elder_Droid_Unique_VO_Instructions",
                "By default, the droids in the Elder's compound on Lehon make beeping noises similar to what T3 and other utility droids do, despite the identical model on Dantooine having a VO that clearly indicates it was programmed to speak verbally, in an ancient version of the Rakatan language. This mod modifies the droid's VO set so it no longer beeps, and instead speaks ancient Rakata like the droid on Dantooine.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1531-k1-legends-elder-droids-unique-vo/") }
                ),
            new Mod(
                "Ajunta Pall's Swords",
                "Rece",
                new string[] { Immersion },
                Recommended,
                new string[] { "Ajunta&#39;s Swords.7z" },
                "Reddit_Ajunta_Palls_Swords_Instructions",
                "Gives the swords in Ajunta Pall's tomb unique stats and the ability to be sold for credits, unlike in vanilla.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/541-ajunta-palls-swords-revamped/") }
                ),
            new Mod(
                "Ajunta Pall's Blade",
                "ebmar",
                new string[] { Appearance },
                Suggested,
                new string[] { "[K1]_Legends_Ajunta_Pall's_Blade_v1.0.2b.7z" },
                "Reddit_Ajunta_Palls_Blade_Instructions",
                "Rather than working on all the Sith specter's weapons, this mod focuses on making Ajunta Pall's true blade a visually unique representation of the terror of the Sith Lord.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1338-k1-legends-ajunta-palls-blade/") }
                ),
            new Mod(
                "JC's Mandalorian Armor",
                "JCarter426",
                new string[] { Appearance, Immersion },
                Recommended,
                new string[] { "JC's Mandalorian Armor for K1 v1.2.zip" },
                "Reddit_JCs_Mandalorian_Armor_Instructions",
                "Makes Mandalorian armor consistent throughout the game, and ensures that all models use the colored ranking system present in KOTOR.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1454-jcs-mandalorian-armor-for-k1/") }
                ),
            new Mod(
                "Weapon Stats Rebalance",
                "TK-664",
                new string[] { Mechanics },
                Essential,
                new string[] { "Weapon Base Stats Re-balance K1.rar" },
                "Weapon_Base_Stats_Rebalance_Instructions",
                "In the original KOTOR blasters are significantly underpowered, both in base damage and critical hit range. This mod alters blasters along the same lines KOTOR 2 did, increasing their versatility especially on Taris.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1248-weapon-base-stats-re-balance-k1/") }
                ),
            new Mod(
                "HQ Gaffi Stick",
                "Fallen Guardian",
                new string[] { Graphics },
                Suggested,
                new string[] { "Gaffi Stick Improvement.zip" },
                "HD_Gaffi_Sticks_Instructions",
                "Improves the textures for the gaffi sticks with a unique texture for the chieftain.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/312-gaffi-stick-improvement/") }
                ),
            new Mod(
                "Training Lightsabers",
                "Kexikus",
                new string[] { Immersion },
                Suggested,
                new string[] { "DantTrainingLS-66-1-0.zip" },
                "Reddit_Training_Lightsabers_Instructions",
                "Canonically, Jedi fought with low-power training lightsabers during their training, not swords. This mod provides the PC and Bastila with a training lightsaber for the purposes of the Dantooine training montage, replacing the scene's default longswords.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/66/") }
                ),
            new Mod(
                "Realistic Visual Effects",
                "Shem",
                new string[] { Immersion },
                Recommended,
                new string[] { "visual_effects_k1.7z" },
                "Reddit_Realistic_Visual_Effects_Instructions",
                "Removes the glowing and other unrealistic visual effects when using flurry, critical strike, etc.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/681-realistic-visual-effects/") }
                ),
            new Mod(
                "NPC Alignment Fix",
                "TK-664",
                new string[] { Bug, Immersion },
                Recommended,
                new string[] { "NPC_Alignment_Fix_v1_1.rar" },
                "NPC_Alignment_Fix_Instructions",
                "Corrects a vanilla oversight where many enemies did not have an alignment at all, thereby rendering most items which gave bonus damage/resistances to LS/DS pointless.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1866-npc-alignment-fix/") }
                ),
            new Mod(
                "True 3D Sound",
                "kcat",
                new string[] { Immersion },
                Suggested,
                new string[] { "DSOAL - True 3D Sound for Headphones (HRTF mod) v1.31a-65094-v1-31a-1559689726.zip" },
                "Reddit_True_3D_Sound_Instructions",
                "Yes, that's taking you to the New Vegas nexus. No, you're not crazy, and neither am I (yet). This mod works for KOTOR as well, and patches in directional sound to the game, provided you have the necessary hardware (only useful with headphones or surround-sound equipment) and Windows software (I'm unsure of its functionality on other systems).",
                new Uri[] { new Uri("https://www.nexusmods.com/newvegas/mods/65094") }
                ),
            new Mod(
                "Remove Duplicate TGA/TPC",
                "Flachzangen",
                new string[] { Patch },
                Essential,
                new string[] { "Remove Duplicate TGA-TPC-1384-1-2-1616219479.zip" },
                "Remove_Duplicate_Files_Instructions",
                "This is a script written by Flachzangen which allows you to remove duplicate .TGA or .TPC files in your game directory. Files with the .TPC filetype take priority, so for several of the patches we've downloaded which are of the .tga filetype, we need to delete any .TPC duplicates in order to get them to read properly. That's what this script will do.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1384") }
                ),
            new Mod(
                "Ultimate Character Overhaul Patches",
                "ShiningRedHD",
                new string[] { Patch, Graphics },
                Essential,
                new string[] {
                    "JC's Minor Fixes - Compatibility Patch-1282-4-1-1629713341.rar",
                    "KOTOR 1 Community Patch - Compatibility Patch-1282-4-1-1629713397.rar",
                    "Better Twi'lek Male Heads - Compatibility Patch-1282-4-1-1629713230.rar",
                    "JC's Mandalorian Armor - Compatibility Patch-1282-4-1-1629713289.rar",
                    "Miscellaneous Compatibility Patches-1282-4-1-1629713437.rar",
                    "Republic Soldier's New Shade - Compatibility Patch-1282-4-1-1629713494.rar"
                },
                "Reddit_Ultimate_Character_Overhaul_Patches_Instructions",
                "This is the point at which we're going to install all the various patches produced for the Ultimate Character Overhaul for any of the other texture mods which you've installed.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1282?tab=files") }
                ),
            new Mod(
                "Turret Cockpit Widescreen",
                "MadDerp",
                new string[] { Bug },
                Suggested,
                new string[] { "ws models for swkotor-1211-0-22-1550195260.zip" },
                "Widescreen_Cockpit_And_Racing_Instructions",
                "Fixes visual issues in the turret cockpit caused by widescreen showing angles which were never supposed to be visible.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1211") }
                ),
            new Mod(
                "KOTOR High Resolution Menus",
                "ndix UR",
                new string[] { Graphics },
                Essential,
                new string[] { "k1hrm-1.5.7z" },
                "KOTOR_High_Resoultion_Menus_Instructions",
                "Edits your game's .exe file to allow the in-game menus to be represented at your game's edited resolution rather than the permanent 800x600 of the default port. This hack will only work on the GoG, 4-disk, iOS, and UniWS-patched Steam versions of the game; for it to be effective, the game must be pre-patched to your widescreen resolution of choice!",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1159-kotor-high-resolution-menus/") }
                ),
            // Use after widescreen menus installation
            new Mod(
                "Galaxy Map Fix Pack",
                "Kexikus",
                new string[] { Graphics, Immersion },
                Suggested,
                new string[] { "K1 Galaxy Map Fix Pack.zip", "HR Menu Patch.zip" },
                "Galaxy_Map_Fix_Pack_Instructions",
                "Fixes the positioning of planets on the Ebon Hawk’s galaxy map so they are in their canonical positions.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1068-k1-galaxy-map-fix-pack/") }
                ),
            new Mod(
                "HD UI Menu Pack",
                "ndix UR",
                new string[] { Patch },
                Essential,
                new string[] { "hd_ui_menupack_PV.7z" },
                "Reddit_HD_UI_Menu_Pack_Instructions",
                "While the previous mod allows the in-game menus to display at higher resolutions, it doesn't include the rebuilt icons and UI elements that would make those menus appear functional and sharp at higher resolution. This mod is designed to visually improve all the various menu UI elements so they're functional and clear at the higher resolutions. For all intents, it's a mandatory patch of the above mod.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1226-hd-ui-menu-pack/") }
                ),
            new Mod(
                "Workbench Upgrade Screen Camera Tweak",
                "Darth Parametric",
                new string[] { Graphics },
                Optional,
                new string[] { "[K1]_Workbench_Upgrade_Screen_Camera_Tweak.7z" },
                "Reddit_Workbench_Upgrade_Screen_Camera_Tweak_Instructions",
                "A camera tweak for running the game at higher resolutions intended to allow you to examine weapon models with a little bit more detail in the Workbench upgrade screen.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1742-workbench-upgrade-screen-camera-tweak-for-k1/") }
                ),
            new Mod(
                "Pretty Good! Icons",
                "ajdrenter",
                new string[] { Graphics },
                Recommended,
                new string[] { "Pretty Good! Icons for KotOR 1.0.7z" },
                "Reddit_Pretty_Good_Icons_Instructions",
                "A comprehensive upscale of all the various icons in the game. Very well-done and essential for visual clarity while using HR Menus.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1815-pretty-good-icons-for-kotor/") }
                ),
            new Mod(
                "Widescreen Fade Fix",
                "Doiinko",
                new string[] { Bug },
                Suggested,
                new string[] { "KOTOR 1 Fade widescreen fix.zip" },
                "Reddit_Widescreen_Fade_Fix_Instructions",
                "At modded resolutions, part of the screen fades in at a different speed than the rest of the screen. This simple mod fixes the fade so it's uniform.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1792-kotor-widescreen-fade-fix/") }
                ),
            new Mod(
                "Main Menu Widescreen Fix",
                "DarthParametric",
                new string[] { Bug },
                Recommended,
                new string[] { "[K1]_Main_Menu_Widescreen_Fix_v1.2.7z" },
                "Main_Menu_Widescreen_Fix_Instructions",
                "Like the turret cockpit, by default the game's main menu isn't intended to be viewed in widescreen. This fix widens the viewing angle of the main menu and moves the smoke effects to the edge of the screen, so the menu appears as it should even in higher resolutions.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1173-k1-main-menu-widescreen-fix/") }
                ),
            new Mod(
                "KOTOR Remastered Cutscenes (720)",
                "Naelavok",
                new string[] { Graphics },
                Essential,
                new string[] { "Resolution 1280x720-1306-1-1-1575389942.zip" },
                "Reddit_KOTOR_Remastered_Cutscenes_Instructions",
                "Using predictive AI, /u/naelavok has upscaled the cutscenes for both games out of their horrendous default resolution, to be much more crisp and viewable. A movie replacer like this is necessary to fix the fullscreen bug (plus they're just really good), so it's hugely recommended to use it whether you experience issues with fullscreen play or not.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1306") }
                ),
            new Mod(
                "KOTOR Remastered Cutscenes (768)",
                "Naelavok",
                new string[] { Graphics },
                Essential,
                new string[] { "Resolution 1366x768-1306-1-1-1575389946.zip" },
                "Reddit_KOTOR_Remastered_Cutscenes_Instructions",
                "Using predictive AI, /u/naelavok has upscaled the cutscenes for both games out of their horrendous default resolution, to be much more crisp and viewable. A movie replacer like this is necessary to fix the fullscreen bug (plus they're just really good), so it's hugely recommended to use it whether you experience issues with fullscreen play or not.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1306") }
                ),
            new Mod(
                "KOTOR Remastered Cutscenes (1080)",
                "Naelavok",
                new string[] { Graphics },
                Essential,
                new string[] { "Resolution 1920x1080-1306-1-1-1575389950.zip" },
                "Reddit_KOTOR_Remastered_Cutscenes_Instructions",
                "Using predictive AI, /u/naelavok has upscaled the cutscenes for both games out of their horrendous default resolution, to be much more crisp and viewable. A movie replacer like this is necessary to fix the fullscreen bug (plus they're just really good), so it's hugely recommended to use it whether you experience issues with fullscreen play or not.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1306") }
                ),
            new Mod(
                "KOTOR Remastered Cutscenes (1440)",
                "Naelavok",
                new string[] { Graphics },
                Essential,
                new string[] { "Resolution 2560x1440-1306-1-1-1575389956.zip" },
                "Reddit_KOTOR_Remastered_Cutscenes_Instructions",
                "Using predictive AI, /u/naelavok has upscaled the cutscenes for both games out of their horrendous default resolution, to be much more crisp and viewable. A movie replacer like this is necessary to fix the fullscreen bug (plus they're just really good), so it's hugely recommended to use it whether you experience issues with fullscreen play or not.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1306") }
                ),
            new Mod(
                "KOTOR Remastered Cutscenes (2160)",
                "Naelavok",
                new string[] { Graphics },
                Essential,
                new string[] { "Resolution 3840x2160-1306-1-1-1575389961.zip" },
                "Reddit_KOTOR_Remastered_Cutscenes_Instructions",
                "Using predictive AI, /u/naelavok has upscaled the cutscenes for both games out of their horrendous default resolution, to be much more crisp and viewable. A movie replacer like this is necessary to fix the fullscreen bug (plus they're just really good), so it's hugely recommended to use it whether you experience issues with fullscreen play or not.",
                new Uri[] { new Uri("https://www.nexusmods.com/kotor/mods/1306") }
                ),
            new Mod(
                "Larger Text Fonts",
                "sovietshipgirl",
                new string[] { Bug },
                Recommended,
                new string[] { "LargerTextFontsK1.7z" },
                "Larger_Text_Fonts_Instructions",
                "Inexplicably, the Russian version of the game has larger English font sizes packaged with it, which allows text to appear larger even on English versions of the game. For those who want to play KOTOR at very high resolutions, this can make it a bit more viable, as otherwise the text is often so small it's almost impossible to play.",
                new Uri[] { new Uri("https://deadlystream.com/files/file/1891-larger-text-fonts-for-kotor-1/") }
                ),
        };
    }
}
