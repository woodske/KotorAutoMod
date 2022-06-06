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
        private ObservableCollection<TestModViewModel> _mods;
        public App()
        {
            _mods = new ObservableCollection<TestModViewModel>();
            SupportedMods.supportedMods().ForEach(supportedMod => _mods.Add(new TestModViewModel(supportedMod)));
            _mods[0].isAvailable = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_mods)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
