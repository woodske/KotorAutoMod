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
using System.Collections.Generic;

namespace KotorAutoMod
{
    internal class FormActions
    {
        private ModConfig modConfig;

        private MainViewModel _main;

        private Window window;

        public FormActions(ModConfig modConfig, MainViewModel _main, Window window)
        {
            this.modConfig = modConfig;
            this._main = _main;
            this.window = window;
        }

        public void HandleSwkotorFolderSelect()
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

        public void HandleCompressedModsFolderSelect()
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

        private bool handleApplyModsPreCheck()
        {
            if (String.IsNullOrEmpty(modConfig.compressedModsDirectory))
            {
                MessageBox.Show(window, $"Please select your compressed mods directory");
                return false;
            }

            if (String.IsNullOrEmpty(modConfig.swkotorDirectory))
            {
                MessageBox.Show(window, $"Please select your swkotor directory");
                return false;
            }

            return true;
        }

        public async Task HandleApplyModsSelect(Label eventsLabel)
        {
            if (!handleApplyModsPreCheck()) return;

            _main.SetProgressBarMaximum(Utils.getProgressBarMaximum(modConfig));

            // Apply setup tools
            if (modConfig.firstTimeSetup)
            {
                _main.IterateProgressBarValue("Extracting setup tools");
                Utils.extractSetupTools();

                _main.IterateProgressBarValue("Applying KOTOR exe setup tools");
                await new KOTOR_Editable_Executable_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "KOTOR Editable Executable"), modConfig, this);
                _main.IterateProgressBarValue("Applying Universal Widescreen patcher");
                await new UniWS_Patcher_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "uniws"), modConfig, this);

                //FileUnblocker fileUnblocker = new FileUnblocker();
                //fileUnblocker.Unblock(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch", "4gb_patch.exe"));
                // Four_GB_Patch_Instructions.applyMod(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch"), modConfig, instructionsTextBlock);
            }

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
                    await (Task)applyMod.Invoke(classInstance, parameters);

                    eventsLabel.Content = "";
                }
            }
        }

        public void updateInstructions(string message)
        {
            _main.SetInstructions(message);
        }

        public void HandleModDescriptionSelection(ListBox listBox, List<Mod> modList)
        {
            Mod selectedMod = modList[listBox.SelectedIndex];
            _main.SetDescription(selectedMod);
        }
    }
}
