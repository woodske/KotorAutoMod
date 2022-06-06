using KotorAutoMod.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class MissingModsViewModel : ViewModelBase
    {
        private ObservableCollection<TestModViewModel> _missingMods;

        public ICommand SelectAllMissingModsCommand { get; }

        public ICommand DownloadMissingModsCommand { get; }

        private bool _selectAllMissingModsIsChecked = false;

        public MissingModsViewModel(ObservableCollection<TestModViewModel> mods)
        {
            _missingMods = mods;
            SelectAllMissingModsCommand = new SelectAllMissingModsCommand(this, mods);
            DownloadMissingModsCommand = new DownloadMissingModsCommand(mods);
        }

        public bool SelectAllMissingModsIsChecked
        {
            get { return _selectAllMissingModsIsChecked; }
            set
            {
                _selectAllMissingModsIsChecked = value;
                OnPropertyChanged(nameof(SelectAllMissingModsIsChecked));
            }
        }

        public IEnumerable<TestModViewModel> MissingMods
        {
            get
            {
                _missingMods.ToList().ForEach(mod =>
                {
                    if (!mod.isAvailable)
                    {
                        mod.isChecked = false;
                    }
                });
                return _missingMods.Where(mod => !mod.isAvailable);
            }

            set
            {
                _missingMods = (ObservableCollection<TestModViewModel>)value;
                OnPropertyChanged(nameof(MissingMods));
            }
        }
    }
}
