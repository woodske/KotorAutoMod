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
using KotorAutoMod.Models;

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
    }
}
