using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Commands
{
    internal class OpenModPagesCommand : AsyncCommandBase
    {
        private ObservableCollection<ModViewModel> _mods;

        private ModStore _modStore;

        public OpenModPagesCommand(ModStore modStore)
        {
            _modStore = modStore;


            _modStore.ModListUpdated += OnModsUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnModPropertyChanged;
            }
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<ModViewModel> selectedMods = _mods.Where(mod => !mod.isAvailable && mod.isChecked);
            await Utils.openModLinks(selectedMods);
        }

        public override bool CanExecute(object? parameter)
        {
            return _mods.Any(mod => !mod.isAvailable && mod.isChecked) && base.CanExecute(parameter);
        }

        private void OnModPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModViewModel.isChecked))
            {
                OnCanExecutedChanged();
            }
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged -= OnModPropertyChanged;
            }
            base.Dispose();
        }
    }
}
