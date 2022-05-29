using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress;

namespace KotorAutoMod
{
    internal class ModConfig
    {
        public string swkotorFilePath { get; set; } = string.Empty;

        public string resolution = string.Empty;

        public ObservableCollection<Mod> selectedMods { get; set; } = new ObservableCollection<Mod>();
    }
}
