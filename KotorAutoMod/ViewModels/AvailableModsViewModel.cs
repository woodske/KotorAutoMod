using KotorAutoMod.Commands;
using KotorAutoMod.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class AvailableModsViewModel : ViewModelBase
    {

        private ObservableCollection<ModViewModel> _availableMods;

        private readonly ModStore _modStore;

        private ModConfigViewModel _modConfig;

        private bool _selectAllAvailableModsIsChecked;

        public ICommand ApplyModsCommand { get; }
        public ICommand SelectAllAvailableModsCommand { get; }

        public AvailableModsViewModel(ModStore modStore)
        {
            _modStore = modStore;
            ApplyModsCommand = new ApplyModsCommand(modStore);
            SelectAllAvailableModsCommand = new SelectAllAvailableModsCommand(this, modStore);

            _modStore.ModListUpdated += OnModsUpdated;
            _modStore.ModConfigUpdated += OnModConfigUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            AvailableMods = mods;
        }

        private void OnModConfigUpdated(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
            _modConfig.PropertyChanged += OnModConfigPropertyChanged;
        }

        private void OnModConfigPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.SelectedType)
                || e.PropertyName == nameof(ModConfigViewModel.SelectedImportanceTier)
                )
            {
                OnPropertyChanged(nameof(AvailableMods));
            }
        }

        public IEnumerable<ModViewModel> AvailableMods
        {
            get
            {
                return Utils.filterMods(_availableMods.Where(mod => mod.isAvailable), _modConfig);
            }

            set
            {
                _availableMods = (ObservableCollection<ModViewModel>)value;
                OnPropertyChanged(nameof(AvailableMods));
            }
        }

        public bool SelectAllAvailableModsIsChecked
        {
            get
            {
                return _selectAllAvailableModsIsChecked;
            }
            set
            {
                _selectAllAvailableModsIsChecked = value;
                OnPropertyChanged(nameof(SelectAllAvailableModsIsChecked));
            }
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            _modStore.ModConfigUpdated -= OnModConfigUpdated;
            _modConfig.PropertyChanged -= OnModConfigPropertyChanged;
            base.Dispose();
        }
    }
}
