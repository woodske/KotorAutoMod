namespace KotorAutoMod.ViewModels
{
    public class DescriptionViewModel : ViewModelBase
    {
        private ModViewModel _mod;
        public ModViewModel Mod
        {
            get
            {
                return _mod;
            }
            set
            {
                _mod = value;
                OnPropertyChanged(nameof(Mod));
            }
        }
    }
}
