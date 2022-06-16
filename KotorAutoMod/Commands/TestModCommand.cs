using KotorAutoMod.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Commands
{
    internal class TestModCommand : AsyncCommandBase
    {
        private ModStore _modStore;

        public TestModCommand(ModStore modStore)
        {
            _modStore = modStore;
        }

        protected override Task ExecuteAsync(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
