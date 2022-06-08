using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Stores
{
    public class ModStore
    {
        public event Action<ObservableCollection<ModViewModel>> ModListUpdated;
        public event Action<ModConfigViewModel> ModConfigUpdated;

        public void updateModsList(ObservableCollection<ModViewModel> mods)
        {
            ModListUpdated?.Invoke(mods);
        }

        public void updateModConfig(ModConfigViewModel modConfig)
        {
            ModConfigUpdated?.Invoke(modConfig);
        }

    }
}
