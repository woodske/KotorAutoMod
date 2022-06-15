using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    public class ApplyModsCommand : AsyncCommandBase
    {
        private ModStore _modStore;
        private ModConfigViewModel _modConfig;
        private ObservableCollection<ModViewModel> _mods;

        public ApplyModsCommand(ModStore modStore)
        {
            _modStore = modStore;
            _modStore.ModListUpdated += OnModsUpdated;
            _modStore.ModConfigUpdated += OnModConfigUpdate;
        }

        private void OnModConfigUpdate(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
            _modConfig.PropertyChanged += OnModConfigPropertyChanged;
        }

        private void OnModConfigPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.SwkotorDirectory)
                || e.PropertyName == nameof(ModConfigViewModel.CompressedModsDirectory)
                || e.PropertyName == nameof(ModConfigViewModel.SelectedAspectRatio)
                || e.PropertyName == nameof(ModConfigViewModel.SelectedResolution)
                )
            {
                OnCanExecutedChanged();
            }
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnModPropertyChanged;
            }
        }

        private void OnModPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModViewModel.isChecked) || e.PropertyName == nameof(ModConfigViewModel.FirstTimeSetupIsChecked))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            bool needsSelectedAspectRatioAndResolutionValues = _modConfig.needsAspectRatioAndResolution()
                ? (String.IsNullOrEmpty(_modConfig.SelectedAspectRatio) || String.IsNullOrEmpty(_modConfig.SelectedResolution))
                : false;

            return !String.IsNullOrEmpty(_modConfig.SwkotorDirectory)
                && !String.IsNullOrEmpty(_modConfig.CompressedModsDirectory)
                && !needsSelectedAspectRatioAndResolutionValues
                && base.CanExecute(parameter);
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<ModViewModel> selectedMods = _mods.Where(mod => mod.isAvailable && mod.isChecked);
            _modConfig.ProgressBarMaximum = Utils.getProgressBarMaximum(_modConfig, selectedMods);
            _modConfig.ProgressBarValue = 0;
            await Utils.applyMods(_modConfig, selectedMods);
            _modConfig.updateTaskProgress("Finished");
            _modConfig.Instructions = "Finished modding, enjoy KotoR!";
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            _modConfig.PropertyChanged -= OnModConfigPropertyChanged;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged -= OnModPropertyChanged;
            }
            base.Dispose();
        }
    }
}
