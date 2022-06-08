using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ObservableCollection<ModViewModel> _mods;

        private ModConfigViewModel _config;

        private ModStore _modStore;
        public App()
        {
            _modStore = new ModStore();
            _mods = new ObservableCollection<ModViewModel>();
            _config = new ModConfigViewModel();
            SupportedMods.supportedMods().ForEach(supportedMod => _mods.Add(new ModViewModel(supportedMod)));
            _mods[0].isAvailable = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_mods, _config, _modStore)
            };
            _modStore.updateModsList(_mods);
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
