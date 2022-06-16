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

            modConfig.SelectedAspectRatio = "16:10";
            //modConfig.SelectedResolution = "2560x1440";

            string modName = "HD NPC Portraits";
            ModViewModel selectedMod = new ModViewModel(SupportedMods.supportedMods.First(mod => mod.ListName == modName));
            string modDirectory = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName[0]));

            await new HD_NPC_Portraits_Instructions().applyMod(new List<string> { modDirectory }, modConfig, selectedMod);

        }
    }
}
