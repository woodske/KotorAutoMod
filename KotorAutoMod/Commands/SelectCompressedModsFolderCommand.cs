using KotorAutoMod.Stores;
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
        private ModStore _modStore;

        public SelectCompressedModsFolderCommand(ModConfigViewModel modConfigViewModel, ModStore modStore)
        {
            _modConfigViewModel = modConfigViewModel;
            _modStore = modStore;
        }

        public override void Execute(object? parameter)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the folder containing the compressed mods.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                _modConfigViewModel.CompressedModsDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfigViewModel.CompressedModsDirectory);

            _modStore.updateModsList(Utils.getMods(_modConfigViewModel.CompressedModsDirectory));
        }
    }
}
