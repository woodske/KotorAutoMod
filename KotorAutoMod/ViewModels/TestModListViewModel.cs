using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.ViewModels
{
    public class TestModListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TestModViewModel> _mods;

        public ObservableCollection<TestModViewModel> Mods => _mods;

        public TestModListViewModel(ObservableCollection<TestModViewModel> mods)
        {
            _mods = mods;
        }
    }
}
