using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.ViewModels
{
    public class TestModViewModel : ViewModelBase
    {
        private readonly Mod _mod;

        public string ListName => _mod.ListName;
        public string Author => _mod.Author;
        public string Importance => _mod.Importance;
        public string ModFileName => _mod.ModFileName;
        public string InstructionsName => _mod.InstructionsName;
        public string Description => _mod.Description;
        public Uri DownloadLink => _mod.DownloadLink;
        public Uri ModPage => _mod.ModPage;
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

        public TestModViewModel(Mod mod)
        {
            _mod = mod;
        }
    }
}
