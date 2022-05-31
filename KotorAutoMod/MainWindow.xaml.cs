using System.IO;
using System.Windows;
using System.Windows.Controls;
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
            InitializeWpf();
            InitializeSetupMods();
        }

        private void InitializeConfig()
        {
            //todo: programatically set compressed mods directory
            modConfig.selectedMods = Utils.getAvailableMods(SupportedMods.supportedMods(), "D:\\compressedMods");       
        }

        private void InitializeWpf()
        {
            ModList.DataContext = modConfig.selectedMods;
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
            formActions.HandleApplyModsSelect(InstructionsTextBlock);
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

           Quicker_TSL_Patching_Instructions.applyMod(Path.Combine(testModConfig.compressedModsDirectory, "Script-1214-1-0"), testModConfig, InstructionsTextBlock);
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
