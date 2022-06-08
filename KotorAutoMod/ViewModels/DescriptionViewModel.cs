using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
