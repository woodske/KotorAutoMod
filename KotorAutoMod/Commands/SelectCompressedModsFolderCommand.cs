using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System;
using System.Diagnostics;
using System.Windows;

namespace KotorAutoMod.Commands
{
    public class SelectCompressedModsFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfigViewModel;

        public SelectCompressedModsFolderCommand(ModConfigViewModel modConfigViewModel)
        {
            _modConfigViewModel = modConfigViewModel;
        }

        public override void Execute(object? parameter)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the folder containing the compressed mods.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                MessageBox.Show($"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}");
                _modConfigViewModel.CompressedModsDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfigViewModel.CompressedModsDirectory);
        }
    }
}
