using KotorAutoMod.Stores;
using KotorAutoMod.SupportedMods;
using KotorAutoMod.ViewModels;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    internal class OpenInstructionsSetCommand : AsyncCommandBase
    {
        private ModConfigViewModel _modConfig;
        private ModStore _modStore;

        public OpenInstructionsSetCommand(ModStore modStore)
        {
            _modStore = modStore;
            _modStore.ModConfigUpdated += OnModConfigUpdate;
        }

        private void OnModConfigUpdate(ModConfigViewModel modConfig)
        {
            _modConfig = modConfig;
            _modConfig.PropertyChanged += OnModConfigPropertyChanged;
        }

        private void OnModConfigPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ModConfigViewModel.InstructionsSource))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !String.IsNullOrEmpty(_modConfig.InstructionsSource) && base.CanExecute(parameter);
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            Uri modUri = Common.getInstructionsSet().Find((instructionsSet) => instructionsSet.InstructionSetName == _modConfig.InstructionsSource).InstructionsSetUri;
            await Utils.openUrl(modUri);
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            base.Dispose();
        }
    }
    
}
