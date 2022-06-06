using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KotorAutoMod.ViewModels
{
    public class ModListViewModel : ViewModelBase
    {
        private ObservableCollection<Mod> _availableModsList;

        private ObservableCollection<Mod> _missingModsList;

        public ObservableCollection<Mod> AvailableModsList
        {
            get
            {
                return _availableModsList;
            }
            set
            {
                _availableModsList = value;
                OnPropertyChanged(nameof(AvailableModsList));
            }
        }

        public ObservableCollection<Mod> MissingModsList
        {
            get
            {
                return _missingModsList;
            }
            set
            {
                _missingModsList = value;
                OnPropertyChanged(nameof(MissingModsList));
            }
        }
    }
}
