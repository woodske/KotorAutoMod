using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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

            _main.SetInstructions("Initial Instructions");  
        }

        private void UpdateTextBlockAndRunExe_Click(object sender, RoutedEventArgs e)
        {
            _main.SetInstructions("Before Exe - I want this to show up");

            string executablePath = Path.Combine(Utils.getResourcesDirectory(), "uniws", "uniws.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.FileName = executablePath;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

            _main.SetInstructions("After Exe");
        }

        private void InitializeConfig()
        {
            // Testing
            modConfig.swkotorDirectory = "D:\\test";
            modConfig.compressedModsDirectory = "D:\\compressedMods";
            modConfig.selectedResolution = "1234x80";
            modConfig.selectedAspectRatio = "16:9";

            //todo: programatically set compressed mods directory
            formActions = new FormActions(modConfig, _main, this, InstructionsTextBlock);
            ObservableCollection<Mod> availableMods = Utils.getAvailableMods(SupportedMods.supportedMods(), "D:\\compressedMods");
            modConfig.selectedMods = availableMods;
            modConfig.missingMods = SupportedMods.supportedMods().Where(supportedMod => !availableMods.ToList().Exists(availableMod => availableMod.ListName.Equals(supportedMod.ListName))).ToList();

            Debug.WriteLine("Available Mods");
            foreach(Mod mod in modConfig.selectedMods)
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
            //ModList.DataContext = modConfig.selectedMods;
            _main.SetAvailableModsList(modConfig.selectedMods);
            _main.SetUnavailableModsList(modConfig.missingMods);
            _main.SetDescription(modConfig.selectedMods[0]);
            ValidAspectRatiosComboBox.ItemsSource = modConfig.validAspectRatios;
            ValidScreenResolutionsComboBox.ItemsSource = Utils.getAvailableScreenResolutionSelections(modConfig);
        }

        private void InitializeSetupMods()
        {
            FileUnblocker fileUnblocker = new FileUnblocker();
            Utils.extractSetupTools();
            fileUnblocker.Unblock(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch", "4gb_patch.exe"));
        }

        private void SelectSwkotorFolderButton_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleSwkotorFolderSelect(this);
        }

        private void ApplyMods_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleApplyModsSelect(InstructionsTextBlock, EventLabel);
        }

        private void CompressedModsFolderButton_Click(object sender, RoutedEventArgs e)
        {
            formActions.HandleCompressedModsFolderSelect(this);
        }

        private void TestModInstall_Click(object sender, RoutedEventArgs e)
        {
            ModConfig testModConfig = new ModConfig();
            testModConfig.swkotorDirectory = "D:\\test";
            testModConfig.compressedModsDirectory = "D:\\compressedMods";
            testModConfig.selectedResolution = "1234x80";
            testModConfig.selectedAspectRatio = "16:9";

            string folderName = "KOTOR Editable Executable";

            //KOTOR_Editable_Executable_Instructions.applyMod(Path.Combine(testModConfig.compressedModsDirectory, folderName), testModConfig, formActions);
            formActions.updateInstructions("hello");
            new KOTOR_Editable_Executable_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), folderName), testModConfig, formActions);
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

        private void AvailableModsList_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            Mod selectedMod = modConfig.selectedMods[listBox.SelectedIndex];
            _main.SetDescription(selectedMod);
        }

        private void UnvailableModsList_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            Mod selectedMod = modConfig.missingMods[listBox.SelectedIndex];
            _main.SetDescription(selectedMod);
        }
    }
}
