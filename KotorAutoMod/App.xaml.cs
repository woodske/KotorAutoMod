using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System.Windows;

namespace KotorAutoMod
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ModStore _modStore;
        public App()
        {
            _modStore = new ModStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
