namespace KotorAutoMod.ViewModels
{
    public class CheckBoxViewModel : ViewModelBase
    {
        private bool _selectAllMissingModsChecked;

        public bool SelectAllMissingModsChecked
        {
            get { return _selectAllMissingModsChecked; }
            set
            {
                _selectAllMissingModsChecked = value;
                OnPropertyChanged(nameof(SelectAllMissingModsChecked));
            }
        }
    }
}
