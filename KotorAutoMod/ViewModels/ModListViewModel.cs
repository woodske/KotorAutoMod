using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KotorAutoMod.ViewModels
{
    public class ModListViewModel : ObservableObject
    {
        private ObservableCollection<Mod> _availableModsList;

        private List<Mod> _unavailableModsList;

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

        public List<Mod> UnavailableModsList
        {
            get
            {
                return _unavailableModsList;
            }
            set
            {
                _unavailableModsList = value;
                OnPropertyChanged(nameof(UnavailableModsList));
            }
        }
    }
}
