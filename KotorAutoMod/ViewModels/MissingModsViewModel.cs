using KotorAutoMod.Commands;
using KotorAutoMod.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class MissingModsViewModel : ViewModelBase
    {
        private ObservableCollection<ModViewModel> _missingMods;

        private ModStore _modStore;

        public ICommand SelectAllMissingModsCommand { get; }

        public ICommand OpenModPagesCommand { get; }

        private bool _selectAllMissingModsIsChecked = false;

        public MissingModsViewModel(ModStore modStore)
        {
            _modStore = modStore;
            SelectAllMissingModsCommand = new SelectAllMissingModsCommand(this, modStore);
            OpenModPagesCommand = new OpenModPagesCommand(modStore);
            _modStore.ModListUpdated += OnModsUpdated;
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            MissingMods = mods;
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

        public IEnumerable<ModViewModel> MissingMods
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
                _missingMods = (ObservableCollection<ModViewModel>)value;
                OnPropertyChanged(nameof(MissingMods));
            }
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            base.Dispose();
        }
    }
}
