using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.IO;
using System.Diagnostics;

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

            System.Diagnostics.Debug.WriteLine(modConfig.swkotorDirectory);
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

            System.Diagnostics.Debug.WriteLine(modConfig.compressedModsDirectory);
        }

        public void HandleApplyModsSelect()
        {
            //todo: skip if swkotor and mod folder isn't selected

            Utils.unzipMods(modConfig.selectedMods, modConfig.compressedModsDirectory);
            
            foreach (Mod supportedMod in SupportedMods.supportedMods())
            {
                if (modConfig.selectedMods.Any(selectedMod => selectedMod.ListName == supportedMod.ListName && selectedMod.isChecked))
                {
                    string modDirectory = Path.Combine(modConfig.compressedModsDirectory, Path.GetFileNameWithoutExtension(supportedMod.ModFileName));
                    string className = $"KotorAutoMod.Instructions.{supportedMod.InstructionsName}";

                    // Invoke the 'applyMod' method in the appropriate instruction class
                    var type = Type.GetType(className);
                    var applyMod = type.GetMethod("applyMod");
                    object[] parameters = new object[] { modDirectory, modConfig };
                    applyMod.Invoke(null, parameters);
                }
            }
            
            Utils.removeUnzippedFiles(modConfig.selectedMods);
        }
    }
}
