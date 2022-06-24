using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    internal class SelectAllAvailableModsCommand : CommandBase
    {
        private readonly ModStore _modStore;
        private ObservableCollection<ModViewModel> _mods;
        private AvailableModsViewModel _availableModsViewModel;

        public SelectAllAvailableModsCommand(AvailableModsViewModel availableModsViewModel, ModStore modStore)
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
            _mods.ToList().ForEach(mod =>
            {
                if (mod.isAvailable)
                {
                    mod.isChecked = _availableModsViewModel.SelectAllAvailableModsIsChecked;
                }
            });
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            base.Dispose();
        }
    }
}
