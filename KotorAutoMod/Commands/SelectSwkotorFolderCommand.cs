using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System.Diagnostics;

namespace KotorAutoMod.Commands
{
    internal class SelectSwkotorFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public SelectSwkotorFolderCommand(ModStore modStore)
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
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                _modConfig.SwkotorDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfig.SwkotorDirectory);
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
