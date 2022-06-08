using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace KotorAutoMod.Commands
{
    public class ApplyModsCommand : CommandBase
    {
        private ModStore _modStore;
        private ObservableCollection<ModViewModel> _mods;
        private AvailableModsViewModel _availableModsViewModel;

        public ApplyModsCommand(AvailableModsViewModel availableModsViewModel, ModStore modStore)
        {
            _modStore = modStore;
            _availableModsViewModel = availableModsViewModel;
            _modStore.ModListUpdated += OnModsUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show("Hello");
        }

        public override bool CanExecute(object? parameter)
        {
            // todo: Check that the compressed mods, swkotor folder, and aspect/resolution (if needed) are selected
            return base.CanExecute(parameter);
        }
    }
}
