using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KotorAutoMod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Singleton instance of modConfig tracks user selections
        private static ModConfig modConfig = new ModConfig();

        FormActions formActions = new FormActions(modConfig);

        public MainWindow()
        {
            InitializeComponent();
            modConfig.selectedMods = Utils.InitializeModList();

            ModList.DataContext = modConfig.selectedMods;
        }

        private void SelectSwkotorFolderButton_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleSwkotorFolderSelect(this);
            Utils.unzipMods(modConfig.selectedMods, modConfig.swkotorFilePath);
            System.Diagnostics.Debug.WriteLine("I'm finished");
        }
    }
}
