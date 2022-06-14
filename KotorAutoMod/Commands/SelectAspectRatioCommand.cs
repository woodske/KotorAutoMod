using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;

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
