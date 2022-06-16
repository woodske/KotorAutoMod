using KotorAutoMod.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal interface IInstructions
    {
        public Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod);
    }
}
