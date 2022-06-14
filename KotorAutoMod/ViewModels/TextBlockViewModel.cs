using System;

namespace KotorAutoMod.ViewModels
{
    public class TextBlockViewModel : ViewModelBase
    {
        private string _instructions;

        private Mod _description;

        public string Instructions
        {
            get
            {
                if (string.IsNullOrEmpty(_instructions))
                    return "No instructions";
                return _instructions;
            }
            set
            {
                _instructions = value;
                OnPropertyChanged(nameof(Instructions));
            }
        }

        public Mod Description
        {
            get
            {
                if (_description == null)
                    return new Mod(
                        "Mod list name",
                        "Author",
                        "Importance",
                        "Mod filename",
                        "Mod instructions file",
                        "Mod description",
                        new Uri("https://www.nexusmods.com/")
                        );
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
