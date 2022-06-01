using Ookii.Dialogs.Wpf;
using System;
using System.Linq;
using System.Windows;
using System.IO;
using System.Diagnostics;
using KotorAutoMod.Instructions;
using System.Windows.Controls;
using System.Threading.Tasks;
using KotorAutoMod.ViewModels;
using System.Windows.Data;

namespace KotorAutoMod
{
    internal class FormActions
    {
        private ModConfig modConfig;

        private MainViewModel _main;

        private Window window;

        private TextBlock textBlock;
        public FormActions(ModConfig modConfig, MainViewModel _main, Window window, TextBlock textBlock)
        {
            this.modConfig = modConfig;
            this._main = _main;
            this.window = window;
            this.textBlock = textBlock;
        }

        public void HandleSwkotorFolderSelect(Window window)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;      

            if ((bool)dialog.ShowDialog(window))
            {
                MessageBox.Show(window, $"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}");
                modConfig.swkotorDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(modConfig.swkotorDirectory);
        }

        public void HandleCompressedModsFolderSelect(Window window)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the folder containing the compressed mods.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog(window))
            {
                MessageBox.Show(window, $"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}");
                modConfig.compressedModsDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(modConfig.compressedModsDirectory);
        }

        public void HandleApplyModsSelect(TextBlock instructionsTextBlock, Label eventsLabel)
        {
            //todo: skip if swkotor and mod folder isn't selected

            // Apply setup tools
            new KOTOR_Editable_Executable_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "KOTOR Editable Executable"), modConfig, this);
            new UniWS_Patcher_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "uniws"), modConfig, this);
            // Four_GB_Patch_Instructions.applyMod(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch"), modConfig, instructionsTextBlock);

            Utils.extractMods(modConfig.selectedMods, modConfig.compressedModsDirectory);
            
            foreach (Mod supportedMod in SupportedMods.supportedMods())
            {
                if (modConfig.selectedMods.Any(selectedMod => selectedMod.ListName == supportedMod.ListName && selectedMod.isChecked))
                {
                    eventsLabel.Content = $"Apply mod: {supportedMod.ListName}";

                    string modDirectory = Path.Combine(modConfig.compressedModsDirectory, Path.GetFileNameWithoutExtension(supportedMod.ModFileName));
                    string className = $"KotorAutoMod.Instructions.{supportedMod.InstructionsName}";

                    // Invoke the 'applyMod' method in the appropriate instruction class
                    var type = Type.GetType(className);
                    var applyMod = type.GetMethod("applyMod");
                    var classInstance = Activator.CreateInstance(type);
                    object[] parameters = new object[] { modDirectory, modConfig, this };
                    applyMod.Invoke(classInstance, parameters);

                    eventsLabel.Content = "";
                }
            }
        }

        public void updateInstructions(string message)
        {
            // Force instructions TextBlock to update
            _main.SetInstructions(message);
            textBlock.GetBindingExpression(TextBlock.TextProperty).UpdateSource();
        }
    }
}
