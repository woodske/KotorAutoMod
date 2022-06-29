using KotorAutoMod.Commands;
using KotorAutoMod.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class MissingModsViewModel : ViewModelBase
    {
        private ObservableCollection<ModViewModel> _missingMods;

        private ModStore _modStore;

        private ModConfigViewModel _modConfig;

        private bool _selectAllMissingModsIsChecked = false;

        public ICommand OpenModPagesCommand { get; }
        public ICommand SelectAllMissingModsCommand { get; }

        public MissingModsViewModel(ModStore modStore)
        {
            _modStore = modStore;
            SelectAllMissingModsCommand = new SelectAllMissingModsCommand(this, modStore);
            OpenModPagesCommand = new OpenModPagesCommand(modStore);

            _modStore.ModListUpdated += OnModsUpdated;
            _modStore.ModConfigUpdated += OnModConfigUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            MissingMods = mods;
        }

        private void OnModConfigUpdated(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
            _modConfig.PropertyChanged += OnModConfigPropertyChanged;
        }

        private void OnModConfigPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.SelectedType) ||
                e.PropertyName == nameof(ModConfigViewModel.SelectedImportanceTier) ||
                e.PropertyName == nameof(ModConfigViewModel.SearchText)
                )
            {
                OnPropertyChanged(nameof(MissingMods));
            }
        }

        public IEnumerable<ModViewModel> MissingMods
        {
            get
            {
                return Utils.filterMods(_missingMods.Where(mod => !mod.isAvailable), _modConfig);
            }

            set
            {
                _missingMods = (ObservableCollection<ModViewModel>)value;
                OnPropertyChanged(nameof(MissingMods));
            }
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

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            _modStore.ModConfigUpdated -= OnModConfigUpdated;
            _modConfig.PropertyChanged -= OnModConfigPropertyChanged;
            base.Dispose();
        }
    }
}
