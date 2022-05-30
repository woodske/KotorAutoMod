using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using System.Diagnostics;
using KotorAutoMod.Instructions;

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
            InitializeConfig();
        }

        private void InitializeConfig()
        {
            //todo: programatically set compressed mods directory
            modConfig.selectedMods = Utils.getAvailableMods(SupportedMods.supportedMods(), "D:\\compressedMods");

            ModList.DataContext = modConfig.selectedMods;
            ValidAspectRatiosComboBox.ItemsSource = modConfig.validAspectRatios;
            ValidScreenResolutionsComboBox.ItemsSource = Utils.getAvailableScreenResolutionSelections(modConfig);        
        }

        private void SelectSwkotorFolderButton_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleSwkotorFolderSelect(this);
        }

        private void ApplyMods_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleApplyModsSelect();
        }

        private void CompressedModsFolderButton_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleCompressedModsFolderSelect(this);
        }

        private void TestModInstall_Click(object sender, RoutedEventArgs e)
        {
            KOTOR_High_Resoultion_Menus_Instructions.applyMod("D:\\compressedMods\\k1hrm-1.5", modConfig);
        }

        private void ValidAspectRatiosComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            modConfig.selectedAspectRatio = (string)ValidAspectRatiosComboBox.SelectedItem;
            ValidScreenResolutionsComboBox.ItemsSource = Utils.getAvailableScreenResolutionSelections(modConfig);
        }

        private void ValidScreenResolutionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            modConfig.selectedResolution = (string)ValidScreenResolutionsComboBox.SelectedItem;
        }
    }
}
