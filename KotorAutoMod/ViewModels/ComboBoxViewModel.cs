namespace KotorAutoMod.ViewModels
{
    public class ComboBoxViewModel : ObservableObject
    {
        private string[] _validAspectRatios = new string[] { };

        private string[] _validScreenResolutions = new string[] { };

        private string _showValidAspectRatios = "Visible";

        private string _showValidScreenResolutions = "Visible";

        public string[] ValidAspectRatios
        {
            get { return _validAspectRatios; }
            set
            {
                _validAspectRatios = value;
                OnPropertyChanged(nameof(ValidAspectRatios));
            }
        }

        public string[] ValidScreenResolutions
        {
            get { return _validScreenResolutions; }
            set
            {
                _validScreenResolutions = value;
                OnPropertyChanged(nameof(ValidScreenResolutions));
            }
        }

        public string ShowValidAspectRatios
        {
            get { return _showValidAspectRatios; }
            set
            {
                _showValidAspectRatios = value;
                OnPropertyChanged(nameof(ShowValidAspectRatios));
            }
        }

        public string ShowValidScreenResolutions
        {
            get { return _showValidScreenResolutions; }
            set
            {
                _showValidScreenResolutions = value;
                OnPropertyChanged(nameof(ShowValidScreenResolutions));
            }
        }
    }
}
