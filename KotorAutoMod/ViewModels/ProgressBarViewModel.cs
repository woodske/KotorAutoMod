namespace KotorAutoMod.ViewModels
{
    public class ProgressBarViewModel : ObservableObject
    {
        private int _value = 0;

        private int _maximum;

        private string _text = "";

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                OnPropertyChanged(nameof(Maximum));
            }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
    }
}
