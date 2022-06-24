using KotorAutoMod.Instructions;
using KotorAutoMod.Stores;
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
            modConfig.SwkotorDirectory = "D:\\test\\";
            modConfig.FirstTimeSetupIsChecked = false;

            _modStore.updateModsList(Utils.getMods(modConfig.ModsDirectory));

            modConfig.SelectedAspectRatio = "16:9";
            modConfig.SelectedResolution = "1920x1080";

            // Manually select mod
            //string modName = "Children NPC Fixes";
            //ModViewModel selectedMod = new ModViewModel(SupportedMods.supportedMods.First(mod => mod.ListName == modName));

            ModViewModel selectedMod = new ModViewModel(SupportedMods.supportedMods[SupportedMods.supportedMods.Count - 1]);
            string modDirectory1 = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName[0]));

            //string modDirectory2 = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName[1]));

            await new Ajunta_Pall_Unique_Appearance_Instructions().applyMod(new List<string> { modDirectory1 }, modConfig, selectedMod);
        }
    }
}
