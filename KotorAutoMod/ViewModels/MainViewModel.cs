﻿using KotorAutoMod.Stores;
using System.Collections.ObjectModel;

namespace KotorAutoMod.ViewModels
{
    public class MainViewModel
    {
        public MissingModsViewModel MissingModsViewModel { get; private set; }

        public AvailableModsViewModel AvailableModsViewModel { get; private set; }

        public ModConfigViewModel ModConfigViewModel { get; private set; }

        public DescriptionViewModel DescriptionViewModel { get; private set; }

        public MainViewModel(ModStore modStore)
        {
            MissingModsViewModel = new MissingModsViewModel(modStore);
            AvailableModsViewModel = new AvailableModsViewModel(modStore);
            ModConfigViewModel = new ModConfigViewModel(modStore);
            DescriptionViewModel = new DescriptionViewModel();

            modStore.updateModsList(new ObservableCollection<ModViewModel>());
        }
    }
}
