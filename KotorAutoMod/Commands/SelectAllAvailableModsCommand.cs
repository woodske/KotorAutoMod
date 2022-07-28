using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace KotorAutoMod.Commands
{
    internal class SelectAllAvailableModsCommand : CommandBase
    {
        private readonly ModStore _modStore;
        private ModConfigViewModel _modConfig;
        private ObservableCollection<ModViewModel> _mods;
        private AvailableModsViewModel _availableModsViewModel;

        public SelectAllAvailableModsCommand(AvailableModsViewModel availableModsViewModel, ModStore modStore)
        {
            _modStore = modStore;
            _availableModsViewModel = availableModsViewModel;

            _modStore.ModListUpdated += OnModsUpdated;
            _modStore.ModConfigUpdated += OnModConfigUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
        }

        private void OnModConfigUpdated(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
        }

        public override void Execute(object? parameter)
        {
            IEnumerable<ModViewModel> filteredMods = Utils.filterMods(_mods.ToList(), _modConfig);


            foreach (ModViewModel mod in filteredMods)
            {
                if (mod.isAvailable)
                {
                    mod.isChecked = _availableModsViewModel.SelectAllAvailableModsIsChecked;
                }
            };
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            _modStore.ModConfigUpdated -= OnModConfigUpdated;
            base.Dispose();
        }
    }
}
