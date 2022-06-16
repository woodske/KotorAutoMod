using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System.Diagnostics;

namespace KotorAutoMod.Commands
{
    public class SelectCompressedModsFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public SelectCompressedModsFolderCommand(ModStore modStore)
        {
            _modStore = modStore;
            _modStore.ModConfigUpdated += OnModConfigUpdate;
        }

        private void OnModConfigUpdate(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
        }

        public override void Execute(object? parameter)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the folder containing the compressed mods.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                _modConfig.ModsDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfig.ModsDirectory);

            _modStore.updateModsList(Utils.getMods(_modConfig.ModsDirectory));
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
