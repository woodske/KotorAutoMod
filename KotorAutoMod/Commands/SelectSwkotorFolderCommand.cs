using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotorAutoMod.Commands
{
    internal class SelectSwkotorFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfigViewModel;
        private ModStore _modStore;

        public SelectSwkotorFolderCommand(ModConfigViewModel modConfigViewModel, ModStore modStore)
        {
            _modConfigViewModel = modConfigViewModel;
            _modStore = modStore;
        }

        public override void Execute(object? parameter)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                MessageBox.Show($"The selected folder was:{Environment.NewLine}{dialog.SelectedPath}");
                _modConfigViewModel.SwkotorDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfigViewModel.SwkotorDirectory);

            _modStore.updateModsList(Utils.getMods(_modConfigViewModel.SwkotorDirectory));
        }
    }
}
