using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;

namespace KotorAutoMod.Commands
{
    internal class SelectInstructionSetCommand : CommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public SelectInstructionSetCommand(ModStore modStore)
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
            if (!string.IsNullOrEmpty(_modConfig.ModsDirectory) && !string.IsNullOrEmpty(_modConfig.InstructionsSource))
            {
                _modStore.updateModsList(Utils.getMods(_modConfig));
            }
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
}
