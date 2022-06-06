using KotorAutoMod.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class AvailableModsViewModel : ViewModelBase
    {
        private ObservableCollection<TestModViewModel> _availableMods;

        private bool _firstTimeSetupIsChecked = true;

        public ICommand ApplyModsCommand { get; }

        public AvailableModsViewModel(ObservableCollection<TestModViewModel> mods)
        {
            _availableMods = mods;
            ApplyModsCommand = new ApplyModsCommand(this, mods);
        }

        public bool FirstTimeSetupIsChecked
        {
            get { return _firstTimeSetupIsChecked; }
            set
            {
                _firstTimeSetupIsChecked = value;
                OnPropertyChanged(nameof(FirstTimeSetupIsChecked));
            }
        }

        public IEnumerable<TestModViewModel> AvailableMods
        {
            get
            {
                return _availableMods.Where(mod => mod.isAvailable);
            }

            set
            {
                _availableMods = (ObservableCollection<TestModViewModel>)value;
                OnPropertyChanged(nameof(AvailableMods));
            }
        }
    }
}
