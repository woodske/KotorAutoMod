using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Commands
{
    internal class DownloadMissingModsCommand : CommandBase
    {
        private ObservableCollection<TestModViewModel> _mods;

        public DownloadMissingModsCommand(ObservableCollection<TestModViewModel> mods)
        {
            _mods = mods;

            foreach (var mod in _mods)
            {
                mod.PropertyChanged += OnViewModelPropertyChanged;
            }
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show("Download Me");
        }

        public override bool CanExecute(object? parameter)
        {
            return _mods.Any(mod => !mod.isAvailable && mod.isChecked) && base.CanExecute(parameter);
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(TestModViewModel.isChecked))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
