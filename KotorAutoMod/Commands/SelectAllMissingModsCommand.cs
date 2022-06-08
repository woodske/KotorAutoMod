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
    public class SelectAllMissingModsCommand : CommandBase
    {
        private readonly ModStore _modStore;
        private ObservableCollection<ModViewModel> _mods;
        private MissingModsViewModel _missingModsViewModel;

        public SelectAllMissingModsCommand(MissingModsViewModel missingModsViewModel, ModStore modStore)
        {
            _modStore = modStore;
            _missingModsViewModel = missingModsViewModel;
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
                if (!mod.isAvailable)
                {
                    mod.isChecked = _missingModsViewModel.SelectAllMissingModsIsChecked;
                }
            });
        }
    }
}
