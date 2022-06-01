using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KotorAutoMod.ViewModels
{
    public class MainViewModel
    {
        public TextBlockViewModel TextBlock { get; private set; }
        public ModListViewModel ModList { get; private set; }

        public MainViewModel()
        {
            TextBlock = new TextBlockViewModel();
            ModList = new ModListViewModel();
        }

        public void SetInstructions(string instructions)
        {
            TextBlock.Instructions = instructions;
        }

        public void SetAvailableModsList(ObservableCollection<Mod> modList)
        {
            ModList.AvailableModsList = modList;
        }

        public void SetUnavailableModsList(List<Mod> modList)
        {
            ModList.UnavailableModsList = modList;
        }

        public void SetDescription(Mod mod)
        {
            TextBlock.Description = mod;
        }
    }
}
