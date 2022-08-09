using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System.Diagnostics;
using System.IO;
using System.Windows;

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

            if (!File.Exists(Path.Combine(_modConfig.SwkotorDirectory, "swkotor.exe"))) {
                MessageBox.Show(
                    "No swkotor.exe found in selected folder. Make sure that this is the swkotor game folder.", 
                    "No swkotor.exe file found", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error
                    );
            }
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
