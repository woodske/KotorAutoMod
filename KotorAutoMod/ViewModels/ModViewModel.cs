using System;

namespace KotorAutoMod.ViewModels
{
    public class ModViewModel : ViewModelBase
    {
        private readonly Mod _mod;

        public string ListName => _mod.ListName;
        public string Author => _mod.Author;
        public string[] Type => _mod.Type;
        public string CombinedType => String.Join("/", _mod.Type);
        public string Importance => _mod.Importance;
        public string[] ModFileName => _mod.ModFileName;
        public string CombinedModFileName => String.Join(" && ", _mod.ModFileName);
        public string InstructionsName => _mod.InstructionsName;
        public string Description => _mod.Description;
        public Uri ModPage => _mod.ModPage;
        public string AdditionalInformation => _mod.AdditionalInformation;
        public bool isChecked
        {
            get => _mod.isChecked;
            set
            {
                _mod.isChecked = value;
                OnPropertyChanged(nameof(isChecked));
            }
        }
        public bool isAvailable
        {
            get => _mod.isAvailable;
            set
            {
                _mod.isAvailable = value;
                OnPropertyChanged(nameof(isAvailable));
            }
        }

        public ModViewModel(Mod mod)
        {
            _mod = mod;
        }
    }
}
