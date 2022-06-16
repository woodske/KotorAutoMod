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

            modConfig.CompressedModsDirectory = "D:\\compressedMods\\";
            modConfig.SwkotorDirectory = "D:\\test\\";
            modConfig.FirstTimeSetupIsChecked = false;

            _modStore.updateModsList(Utils.getMods(modConfig.CompressedModsDirectory));

            modConfig.SelectedAspectRatio = "16:10";
            //modConfig.SelectedResolution = "2560x1440";

            string modName = "HD Loadscreens (4:3)";
            ModViewModel selectedMod = new ModViewModel(SupportedMods.supportedMods.First(mod => mod.ListName == modName));
            string modDirectory = Path.Combine(modConfig.CompressedModsDirectory, Path.GetFileNameWithoutExtension(selectedMod.ModFileName));

            await new HD_Loadscreens_Instructions().applyMod(modDirectory, modConfig, selectedMod);

        }
    }
}
