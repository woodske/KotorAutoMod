using KotorAutoMod.Models;
using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;

namespace KotorAutoMod.Commands
{
    internal class SelectAspectRatioCommand : CommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public SelectAspectRatioCommand(ModStore modStore)
        {
            _modStore = modStore;
            _modStore.ModConfigUpdated += OnModConfigUpdate;
        }

        private void OnModConfigUpdate(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
        }

        public override void Execute(object? parameter)
        {
            _modConfig.AvailableScreenResolutions = ModConfig.validScreenResolutions[_modConfig.SelectedAspectRatio];
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
