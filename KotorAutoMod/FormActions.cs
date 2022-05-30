using Ookii.Dialogs.Wpf;
using System;
using System.Linq;
using System.Windows;
using System.IO;
using System.Diagnostics;
using KotorAutoMod.Instructions;
using System.Windows.Controls;

namespace KotorAutoMod
{
    internal class FormActions
    {
        public ModConfig modConfig;
        
        public FormActions(ModConfig config)
        {
            modConfig = config;
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

        public void HandleApplyModsSelect(TextBlock textBlock)
        {
            //todo: skip if swkotor and mod folder isn't selected

            // Apply setup tools
            KOTOR_Editable_Executable_Instructions.applyMod(Path.Combine(Utils.getResourcesDirectory(), "KOTOR Editable Executable"), modConfig, textBlock);

            Utils.extractMods(modConfig.selectedMods, modConfig.compressedModsDirectory);
            
            foreach (Mod supportedMod in SupportedMods.supportedMods())
            {
                if (modConfig.selectedMods.Any(selectedMod => selectedMod.ListName == supportedMod.ListName && selectedMod.isChecked))
                {
                    string modDirectory = Path.Combine(modConfig.compressedModsDirectory, Path.GetFileNameWithoutExtension(supportedMod.ModFileName));
                    string className = $"KotorAutoMod.Instructions.{supportedMod.InstructionsName}";

                    // Invoke the 'applyMod' method in the appropriate instruction class
                    var type = Type.GetType(className);
                    var applyMod = type.GetMethod("applyMod");
                    object[] parameters = new object[] { modDirectory, modConfig, textBlock };
                    applyMod.Invoke(null, parameters);
                }
            }
            
            Utils.removeUnzippedFiles(modConfig.selectedMods);
        }
    }
}
