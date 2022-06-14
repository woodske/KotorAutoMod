using KotorAutoMod.Commands;
using KotorAutoMod.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class AvailableModsViewModel : ViewModelBase
    {

        private readonly ModStore _modStore;
        private ObservableCollection<ModViewModel> _availableMods;

        public ICommand ApplyModsCommand { get; }

        public AvailableModsViewModel(ModStore modStore)
        {
            _modStore = modStore;
            ApplyModsCommand = new ApplyModsCommand(this, modStore);

            _modStore.ModListUpdated += OnModsUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            AvailableMods = mods;
        }

        public IEnumerable<ModViewModel> AvailableMods
        {
            get
            {
                return _availableMods.Where(mod => mod.isAvailable);
            }

            set
            {
                _availableMods = (ObservableCollection<ModViewModel>)value;
                OnPropertyChanged(nameof(AvailableMods));
            }
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            base.Dispose();
        }
    }
}
