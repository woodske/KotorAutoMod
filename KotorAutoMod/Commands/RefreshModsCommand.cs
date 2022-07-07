using KotorAutoMod.Stores;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    public class RefreshModsCommand : CommandBase
    {
        private ModStore _modStore;
        private ModConfigViewModel _modConfig;

        public RefreshModsCommand(ModStore modStore)
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
            if (e.PropertyName == nameof(ModConfigViewModel.ModsDirectory))
            {
                OnCanExecutedChanged();
            }
        }

        public override void Execute(object? parameter)
        {
            _modStore.updateModsList(Utils.getMods(_modConfig)); ;
        }

        public override bool CanExecute(object? parameter)
        {
            return !String.IsNullOrEmpty(_modConfig.ModsDirectory)
                && base.CanExecute(parameter);
        }

        public override void Dispose()
        {
            _modStore.ModConfigUpdated -= OnModConfigUpdate;
            _modConfig.PropertyChanged -= OnModConfigPropertyChanged;
            base.Dispose();
        }
    }
}
