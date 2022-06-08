using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Commands
{
    internal class SelectAspectRatioCommand : CommandBase
    {
        private ModConfigViewModel _modConfigViewModel;

        public SelectAspectRatioCommand(ModConfigViewModel modConfigViewModel)
        {
            _modConfigViewModel = modConfigViewModel;
        }

        public override void Execute(object? parameter)
        {
            _modConfigViewModel.AvailableScreenResolutions = ModConfig.validScreenResolutions[_modConfigViewModel.SelectedAspectRatio];
        }
    }
}
