using KotorAutoMod.ViewModels;
using Ookii.Dialogs.Wpf;
using System.Diagnostics;

namespace KotorAutoMod.Commands
{
    internal class SelectSwkotorFolderCommand : CommandBase
    {
        private ModConfigViewModel _modConfigViewModel;

        public SelectSwkotorFolderCommand(ModConfigViewModel modConfigViewModel)
        {
            _modConfigViewModel = modConfigViewModel;
        }

        public override void Execute(object? parameter)
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Please select the swkotor folder.";
            dialog.UseDescriptionForTitle = true;

            if ((bool)dialog.ShowDialog())
            {
                _modConfigViewModel.SwkotorDirectory = dialog.SelectedPath;
            }

            Debug.WriteLine(_modConfigViewModel.SwkotorDirectory);
        }
    }
}
