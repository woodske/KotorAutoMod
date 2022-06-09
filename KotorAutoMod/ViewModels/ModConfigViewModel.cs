using KotorAutoMod.Commands;
using KotorAutoMod.Models;
using KotorAutoMod.Stores;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class ModConfigViewModel : ViewModelBase
    {
        private ModStore _modStore;

        private ObservableCollection<ModViewModel> _mods;

        private string _swkotorDirectory = string.Empty;

        private string _compressedModsDirectory = string.Empty;

        private string _selectedResolution = string.Empty;

        private string _selectedAspectRatio = string.Empty;

        private string[] _availableScreenResolutions = new string[] { };

        private bool _firstTimeSetupIsChecked;

        public ICommand SelectSwkotorFolderCommand { get; }
        public ICommand SelectCompressedModsFolderCommand { get; }
        public ICommand SelectAspectRatioCommand { get; }

        public ModConfigViewModel(ModStore modStore)
        {
            _modStore = modStore;
            SelectSwkotorFolderCommand = new SelectSwkotorFolderCommand(this, _modStore);
            SelectCompressedModsFolderCommand = new SelectCompressedModsFolderCommand(this);
            SelectAspectRatioCommand = new SelectAspectRatioCommand(this);

            _modStore.updateModConfig(this);
            _modStore.ModListUpdated += OnModsUpdated;
        }

        public ModConfig GetModConfig()
        {
            ModConfig modConfig = new ModConfig();
            modConfig.swkotorDirectory = SwkotorDirectory;
            modConfig.compressedModsDirectory = CompressedModsDirectory;
            modConfig.selectedResolution = SelectedResolution;
            modConfig.selectedAspectRatio = SelectedAspectRatio;
            modConfig.firstTimeSetup = FirstTimeSetupIsChecked;

            return modConfig;
        }

        public string SwkotorDirectory
        {
            get
            {
                return _swkotorDirectory;
            }
            set
            {
                _swkotorDirectory = value;
                OnPropertyChanged(nameof(SwkotorDirectory));
            }
        }

        public string CompressedModsDirectory
        {
            get
            {
                return _compressedModsDirectory;
            }
            set
            {
                _compressedModsDirectory = value;
                OnPropertyChanged(nameof(CompressedModsDirectory));
            }
        }

        public string SelectedResolution
        {
            get
            {
                return _selectedResolution;
            }
            set
            {
                _selectedResolution = value;
                OnPropertyChanged(nameof(SelectedResolution));
            }
        }

        public string SelectedAspectRatio
        {
            get
            {
                return _selectedAspectRatio;
            }
            set
            {
                _selectedAspectRatio = value;
                OnPropertyChanged(nameof(SelectedAspectRatio));
            }
        }

        public bool FirstTimeSetupIsChecked
        {
            get
            {
                return _firstTimeSetupIsChecked;
            }
            set
            {
                _firstTimeSetupIsChecked = value;
                OnPropertyChanged(nameof(FirstTimeSetupIsChecked));
            }
        }

        public string[] AvailableAspectRatios
        {
            get
            {
                return ModConfig.validAspectRatios;
            }
        }

        public string[] AvailableScreenResolutions
        {
            get
            {
                if (String.IsNullOrEmpty(_selectedAspectRatio))
                {
                    return new string[] { };
                }
                else
                {
                    return ModConfig.validScreenResolutions[_selectedAspectRatio];
                }
            }
            set
            {
                _availableScreenResolutions = value;
                OnPropertyChanged(nameof(AvailableScreenResolutions));
            }
        }

        public string ShowDisplaySelectionDropdown
        {
            get
            {
                if (needsAspectRatioAndResolution())
                {
                    return "Visible";
                }
                else
                {
                    return "Hidden";
                }
            }
        }

        // We need aspect ratio and screen resolution for first time setup and high resolution menus mod
        public bool needsAspectRatioAndResolution()
        {
            return FirstTimeSetupIsChecked || _mods.Any(mod => mod.ListName == "KOTOR High Resolution Menus" && mod.isAvailable);
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            base.Dispose();
        }
    }
}
