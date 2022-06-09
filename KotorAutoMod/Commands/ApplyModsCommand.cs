using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Commands
{
    public class ApplyModsCommand : AsyncCommandBase
    {
        private ModStore _modStore;
        private ModConfigViewModel _modConfig;
        private ObservableCollection<ModViewModel> _mods;
        private AvailableModsViewModel _availableModsViewModel;

        public ApplyModsCommand(AvailableModsViewModel availableModsViewModel, ModStore modStore)
        {
            _modStore = modStore;
            _availableModsViewModel = availableModsViewModel;
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
            IEnumerable<ModViewModel> selectedMods = _mods.ToList().Where(mod => mod.isAvailable && mod.isChecked);
            await Utils.applyMods(_modConfig, selectedMods);
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            _modConfig.PropertyChanged -= OnModConfigPropertyChanged;
            base.Dispose();
        }
    }
}
