using KotorAutoMod.Commands;
using KotorAutoMod.Models;
using KotorAutoMod.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class ModConfigViewModel : ViewModelBase
    {
        private ModStore _modStore;

        public ObservableCollection<ModViewModel> _mods;

        private string _swkotorDirectory = string.Empty;

        private string _modsDirectory = string.Empty;

        private string _selectedResolution = string.Empty;

        private string _selectedAspectRatio = string.Empty;

        private string[] _availableScreenResolutions = new string[] { };

        private bool _firstTimeSetupIsChecked = true;

        private string _instructions = getInitialInstructions();

        private int _progressBarMaximum = 1;

        private int _progressBarValue = 0;

        private string _activeTask = string.Empty;

        public string[] AvailableAspectRatios => ModConfig.validAspectRatios;

        public string[] ImportanceTiers => SupportedMods.importanceTiers;

        private string _selectedType = string.Empty;

        private string _selectedImportanceTier = string.Empty;

        private string _searchText;

        private string _instructionsSource;

        public string[] InstructionSources => SupportedMods.supportedInstructions;

        public ICommand SelectSwkotorFolderCommand { get; }
        public ICommand SelectModsFolderCommand { get; }
        public ICommand SelectAspectRatioCommand { get; }
        public ICommand RefreshModsCommand { get; }
        public ICommand TestModCommand { get; }
        public ICommand SelectInstructionSetCommand { get; }

        public ModConfigViewModel(ModStore modStore)
        {
            _modStore = modStore;
            SelectSwkotorFolderCommand = new SelectSwkotorFolderCommand(_modStore);
            SelectModsFolderCommand = new SelectModsFolderCommand(_modStore);
            SelectAspectRatioCommand = new SelectAspectRatioCommand(_modStore);
            RefreshModsCommand = new RefreshModsCommand(_modStore);
            TestModCommand = new TestModCommand(_modStore);
            SelectInstructionSetCommand = new SelectInstructionSetCommand(_modStore);

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

        public string ModsDirectory
        {
            get
            {
                return _modsDirectory;
            }
            set
            {
                _modsDirectory = value;
                OnPropertyChanged(nameof(ModsDirectory));
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

        public string SelectedType
        {
            get
            {
                return _selectedType;
            }
            set
            {
                _selectedType = value;
                OnPropertyChanged(nameof(SelectedType));
            }
        }

        public string SelectedImportanceTier
        {
            get
            {
                return _selectedImportanceTier;
            }
            set
            {
                _selectedImportanceTier = value;
                OnPropertyChanged(nameof(SelectedImportanceTier));
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        public string InstructionsSource
        {
            get
            {
                return _instructionsSource;
            }
            set
            {
                _instructionsSource = value;
                OnPropertyChanged(nameof(InstructionsSource));
            }
        }

        public string[] Types
        {
            get
            {
                HashSet<string> typeList = new HashSet<string>();
                typeList.Add("");
                foreach (var mod in _mods)
                {
                    foreach (string type in mod.Type)
                    {
                        typeList.Add(type);
                    }
                }
                return typeList.ToArray();
            }
            set
            {
                OnPropertyChanged(nameof(Types));
            }
        }

        // We need aspect ratio and screen resolution for first time setup and high resolution menus mod
        public bool needsAspectRatioAndResolution()
        {
            string[] modsNeedingAspectRatioOrResolution = new string[] { "KOTOR High Resolution Menus", "HD Loadscreens (16:9)", "HD Loadscreens (4:3)", "Pazaak UI", "Galaxy Map Fix Pack", "Widescreen Fade Fix" };
            return FirstTimeSetupIsChecked || _mods.Any(mod => modsNeedingAspectRatioOrResolution.Contains(mod.ListName) && mod.isAvailable && mod.isChecked);
        }

        private void OnModsUpdated(ObservableCollection<ModViewModel> mods)
        {
            _mods = mods;
            OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnModPropertyChanged;
            }
            OnPropertyChanged(nameof(Types));
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

        private static string getInitialInstructions()
        {
            return "\u2022 On the left are some configurations needed before running the KOTOR Auto Mod tool.\n\n" +
                "\u2022 Check the 'Widescreen Setup' box if this is a fresh install and you want the tool to setup the game for widescreen (highly recommended, some mods may not work without this).\n\n" +
                "\u2022 Select the folder that your swkotor exe lives in as well as the folder where all of your compressed mods live.\n\n" +
                "\u2022 After choosing your compressed mods folder, the mods that are available and compatible with this tool will show up on the left.\n\n" +
                "\u2022 Mods that were not located will show on the right. You will need to download the compressed mod at the link in the mod description and put it in your mods folder. Some mods have multiple files so make sure it matches the filename in the mod description.\n\n" +
                "\u2022 Choose your aspect ratio and screen resolution if prompted.\n\n" +
                "\u2022 Finally, press the 'Apply Mods' button. Some mods require executables to be run and manual clicking on your part. There will be instructions in this box with what to press and what values to enter.\n\n" +
                "For code contributions and feedback, go to:\n" +
                "https://github.com/woodske/KotorAutoMod";
        }
    }
}
