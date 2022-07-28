using KotorAutoMod.Instructions;
using KotorAutoMod.Stores;
using KotorAutoMod.SupportedMods;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    internal class TestModCommand : AsyncCommandBase
    {
        private ModStore _modStore;

        public TestModCommand(ModStore modStore)
        {
            _modStore = modStore;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            ModConfigViewModel modConfig = new ModConfigViewModel(_modStore);

            modConfig.ModsDirectory = "D:\\compressedMods\\";
            modConfig.SwkotorDirectory = "D:\\SteamGames\\steamapps\\common\\swkotor";
            modConfig.FirstTimeSetupIsChecked = false;
            modConfig.InstructionsSource = Common.Reddit;
            modConfig.UseAuto = true;

            _modStore.updateModsList(Utils.getMods(modConfig));

            modConfig.SelectedAspectRatio = "16:9";
            modConfig.SelectedResolution = "250x1440";

            //ModViewModel mod = modConfig._mods.First(mod => mod.ListName.Equals("Ajunta Pall's Swords"));
            //mod.isChecked = false;

            // Manually select mod
            string modName = "NPC Alignment Fix";
            ModViewModel selectedMod = new ModViewModel(Reddit_Kotor_1_Full_Build.supportedModsReddit.First(mod => mod.ListName == modName));

            //ModViewModel selectedMod = new ModViewModel(Reddit_Kotor_1_Full_Build.supportedModsReddit[Reddit_Kotor_1_Full_Build.supportedModsReddit.Count - 1]);
            string modDirectory1 = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName[0]));
            //string modDirectory2 = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName[1]));

            await new NPC_Alignment_Fix_Instructions().applyMod(new List<string> { modDirectory1 }, modConfig, selectedMod);
        }
    }
}
