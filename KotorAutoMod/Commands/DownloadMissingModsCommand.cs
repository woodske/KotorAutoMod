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
    internal class DownloadMissingModsCommand : CommandBase
    {
        private ObservableCollection<ModViewModel> _mods;

        private ModStore _modStore;

        public DownloadMissingModsCommand(ModStore modStore)
        {
            _modStore = modStore;


            _modStore.ModListUpdated += OnModsUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnViewModelPropertyChanged;
            }
        }

        public override void Execute(object? parameter)
        {
            ObservableCollection<ModViewModel> newMods = new ObservableCollection<ModViewModel>();
            ModViewModel newMod1 = new ModViewModel(new Mod(
                "asdf",
                "asdf",
                "asdf",
                "asdf",
                "asdf",
                "asdf",
                new Uri("https://www.nexusmods.com/Core/Libs/Common/Widgets/DownloadPopUp?id=1464&game_id=234"),
                new Uri("https://www.nexusmods.com/kotor/mods/1214")
                ));

            ModViewModel newMod2 = new ModViewModel(new Mod(
                "123",
                "123",
                "123",
                "123",
                "123",
                "123",
                new Uri("https://www.nexusmods.com/Core/Libs/Common/Widgets/DownloadPopUp?id=1464&game_id=234"),
                new Uri("https://www.nexusmods.com/kotor/mods/1214")
                ));

            newMod1.isAvailable = true;
            newMod2.isAvailable = false;

            newMods.Add(newMod1);
            newMods.Add(newMod2);



            _modStore.updateModsList(newMods);
        }

        public override bool CanExecute(object? parameter)
        {
            return _mods.Any(mod => !mod.isAvailable && mod.isChecked) && base.CanExecute(parameter);
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
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
                mod.PropertyChanged -= OnViewModelPropertyChanged;
            }
            base.Dispose();
        }
    }
}
