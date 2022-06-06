using KotorAutoMod.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace KotorAutoMod.Commands
{
    public class ApplyModsCommand : CommandBase
    {
        private ObservableCollection<TestModViewModel> _mods;
        private AvailableModsViewModel _availableModsViewModel;

        public ApplyModsCommand(AvailableModsViewModel availableModsViewModel, ObservableCollection<TestModViewModel> mods)
        {
            _mods = mods;
            _availableModsViewModel = availableModsViewModel;
        }

        public override void Execute(object? parameter)
        {
            MessageBox.Show("Hello");
        }

        public override bool CanExecute(object? parameter)
        {
            // todo: Check that the compressed mods, swkotor folder, and aspect/resolution (if needed) are selected
            return base.CanExecute(parameter);
        }
    }
}
