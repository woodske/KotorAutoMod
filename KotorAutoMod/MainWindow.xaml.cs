using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using KotorAutoMod.Instructions;
using KotorAutoMod.ViewModels;

namespace KotorAutoMod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ModConfig modConfig = new ModConfig();

        MainViewModel _main = new MainViewModel();

        FormActions? formActions;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;

            InitializeConfig();
            InitializeWpf();
            InitializeSetupMods();
        }

        private void InitializeConfig()
        {
            // Testing
            modConfig.swkotorDirectory = "D:\\test";
            modConfig.compressedModsDirectory = "D:\\compressedMods";
            modConfig.selectedResolution = "1234x80";
            modConfig.selectedAspectRatio = "16:9";

            //todo: programatically set compressed mods directory
            formActions = new FormActions(modConfig, _main, this);
            ObservableCollection<Mod> availableMods = Utils.getAvailableMods(SupportedMods.supportedMods(), "D:\\compressedMods");
            modConfig.selectedMods = availableMods;
            modConfig.missingMods = SupportedMods.supportedMods().Where(supportedMod => !availableMods.ToList().Exists(availableMod => availableMod.ListName.Equals(supportedMod.ListName))).ToList();

            Debug.WriteLine("Available Mods");
            foreach (Mod mod in modConfig.selectedMods)
            {
                Debug.WriteLine(mod.ListName);
            }

            Debug.WriteLine("Missing Mods");
            foreach (Mod mod in modConfig.missingMods)
            {
                Debug.WriteLine(mod.ListName);
            }
        }

        private void InitializeWpf()
        {
            _main.SetAvailableModsList(modConfig.selectedMods);
            _main.SetUnavailableModsList(modConfig.missingMods);
            _main.SetDescription(modConfig.selectedMods[0]);
            _main.SetValidAspectRatios(ModConfig.validAspectRatios);
            _main.SetValidScreenResolutions(Utils.getAvailableScreenResolutionSelections(modConfig));

            bool needAspectRatioAndResolution = Utils.needAspectRatioAndResolution(modConfig);
            _main.SetShowValidAspectRatios(needAspectRatioAndResolution);
            _main.SetShowValidScreenResolutions(needAspectRatioAndResolution);

            FirstTimeSetupCheckbox.DataContext = modConfig;
            _main.SetInstructions("Instructions for executables will appear here");
        }

        private void InitializeSetupMods()
        {

        }

        private void SelectSwkotorFolderButton_Click(object sender, RoutedEventArgs e) => formActions.HandleSwkotorFolderSelect();

        private async void ApplyMods_Click(object sender, RoutedEventArgs e) => await formActions.HandleApplyModsSelect();

        private void CompressedModsFolderButton_Click(object sender, RoutedEventArgs e) => formActions.HandleCompressedModsFolderSelect();

        private async void TestModInstall_Click(object sender, RoutedEventArgs e)
        {
            //ModConfig testModConfig = new ModConfig();
            //testModConfig.swkotorDirectory = "D:\\test";
            //testModConfig.compressedModsDirectory = "D:\\compressedMods";
            //testModConfig.selectedResolution = "1234x80";
            //testModConfig.selectedAspectRatio = "16:9";

            //string folderName = "KOTOR Editable Executable";

            ////KOTOR_Editable_Executable_Instructions.applyMod(Path.Combine(testModConfig.compressedModsDirectory, folderName), testModConfig, formActions);
            //_main.SetInstructions("Hello");
            //await new KOTOR_Editable_Executable_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), folderName), testModConfig, formActions);

            //Debug.WriteLine(modConfig.firstTimeSetup);
        }

        private void ValidAspectRatiosComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            modConfig.selectedAspectRatio = (string)ValidAspectRatiosComboBox.SelectedItem;
            ValidScreenResolutionsComboBox.ItemsSource = Utils.getAvailableScreenResolutionSelections(modConfig);
        }

        private void ValidScreenResolutionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => modConfig.selectedResolution = (string)ValidScreenResolutionsComboBox.SelectedItem;

        private void UnvailableModsList_OnClick(object sender, System.Windows.Input.MouseButtonEventArgs e) => formActions.HandleModDescriptionSelection((ListBox)sender, modConfig.missingMods);

        private void AailableModsList_OnClick(object sender, System.Windows.Input.MouseButtonEventArgs e) => formActions.HandleModDescriptionSelection((ListBox)sender, modConfig.selectedMods.ToList());

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.FileName = e.Uri.AbsoluteUri;
            Process.Start(startInfo);
            e.Handled = true;
        }
    }
}
