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
        private ObservableCollection<TestModViewModel> _mods;
        private MissingModsViewModel _missingModsViewModel;

        public SelectAllMissingModsCommand(MissingModsViewModel missingModsViewModel, ObservableCollection<TestModViewModel> mods)
        {
            _mods = mods;
            _missingModsViewModel = missingModsViewModel;
        }

        public override void Execute(object? parameter)
        {
            _missingModsViewModel.MissingMods.ToList().ForEach(mod =>
            {
                if (!mod.isAvailable)
                {
                    mod.isChecked = _missingModsViewModel.SelectAllMissingModsIsChecked;
                }
            });
        }
    }
}
