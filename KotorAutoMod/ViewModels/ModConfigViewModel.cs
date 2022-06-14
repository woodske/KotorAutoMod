using KotorAutoMod.Commands;
using KotorAutoMod.Models;
using KotorAutoMod.Stores;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        private bool _firstTimeSetupIsChecked = true;

        private string _instructions;

        private int _progressBarMaximum = 1;

        private int _progressBarValue = 0;

        private string _activeTask = string.Empty;

        public ICommand SelectSwkotorFolderCommand { get; }
        public ICommand SelectCompressedModsFolderCommand { get; }
        public ICommand SelectAspectRatioCommand { get; }

        public ModConfigViewModel(ModStore modStore)
        {
            _modStore = modStore;
            SelectSwkotorFolderCommand = new SelectSwkotorFolderCommand(this);
            SelectCompressedModsFolderCommand = new SelectCompressedModsFolderCommand(this, _modStore);
            SelectAspectRatioCommand = new SelectAspectRatioCommand(this);

            _modStore.updateModConfig(this);
            _modStore.ModListUpdated += OnModsUpdated;
            this.PropertyChanged += OnModConfigUpdated;
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

        public string Instructions
        {
            get
            {
                return _instructions;
            }
            set
            {
                _instructions = value;
                OnPropertyChanged(nameof(Instructions));
            }
        }

        public int ProgressBarMaximum
        {
            get
            {
                return _progressBarMaximum;
            }
            set
            {
                _progressBarMaximum = value;
                OnPropertyChanged(nameof(ProgressBarMaximum));
            }
        }

        public int ProgressBarValue
        {
            get
            {
                return _progressBarValue;
            }
            set
            {
                _progressBarValue = value;
                OnPropertyChanged(nameof(ProgressBarValue));
            }
        }

        public string ActiveTask
        {
            get
            {
                return _activeTask;
            }
            set
            {
                _activeTask = value;
                OnPropertyChanged(nameof(ActiveTask));
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
            return FirstTimeSetupIsChecked || _mods.Any(mod => mod.ListName == "KOTOR High Resolution Menus" && mod.isAvailable && mod.isChecked);
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnModPropertyChanged;
            }
        }

        private void OnModPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModViewModel.isChecked))
            {
                OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
            }
        }

        private void OnModConfigUpdated(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.FirstTimeSetupIsChecked))
            {
                OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
            }
        }

        public void updateTaskProgress(string activeTask)
        {
            ActiveTask = activeTask;
            ProgressBarValue++;
        }

        public override void Dispose()
        {
            _modStore.ModListUpdated -= OnModsUpdated;
            this.PropertyChanged -= OnModConfigUpdated;
            foreach (var mod in _mods)
            {
                mod.PropertyChanged -= OnModPropertyChanged;
            }
            base.Dispose();
        }
    }
}
