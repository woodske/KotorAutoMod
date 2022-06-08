using KotorAutoMod.Commands;
using KotorAutoMod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KotorAutoMod.ViewModels
{
    public class ModConfigViewModel : ViewModelBase
    {
        private string _swkotorDirectory = string.Empty;

        private string _compressedModsDirectory = string.Empty;

        private string _selectedResolution = string.Empty;

        private string _selectedAspectRatio = string.Empty;

        private string[] _availableScreenResolutions = new string[] { };

        private bool _showDisplaySelectionDropdown;
        public bool ShowDisplaySelectionDropdown
        {
            get
            {
                return _showDisplaySelectionDropdown;
            }
            set
            {
                _showDisplaySelectionDropdown = value;
                OnPropertyChanged(nameof(ShowDisplaySelectionDropdown));
            }
        }
        public ICommand SelectSwkotorFolderCommand { get; }
        public ICommand SelectCompressedModsFolderCommand { get; }

        public ICommand SelectAspectRatioCommand { get; }

        public ModConfigViewModel()
        {
            SelectSwkotorFolderCommand = new SelectSwkotorFolderCommand(this);
            SelectCompressedModsFolderCommand = new SelectCompressedModsFolderCommand(this);
            SelectAspectRatioCommand = new SelectAspectRatioCommand(this);
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
    }
}
