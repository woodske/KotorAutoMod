using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace KotorAutoMod.Commands
{
    public class SelectModsFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public SelectModsFolderCommand(ModStore modStore)
        {
            _modStore = modStore;
            _modStore.ModConfigUpdated += OnModConfigUpdate;
        }

        private void OnModConfigUpdate(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
            _modConfig.PropertyChanged += OnModConfigPropertyChanged;
        }

        private void OnModConfigPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.InstructionsSource))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !String.IsNullOrEmpty(_modConfig.InstructionsSource)
                && base.CanExecute(parameter);
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

            if (!string.IsNullOrEmpty(_modConfig.ModsDirectory))
            {
                _modStore.updateModsList(Utils.getMods(_modConfig));
            }
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
