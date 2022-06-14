using KotorAutoMod.ViewModels;
using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal interface IInstructions
    {
        public Task applyMod(string modDirectory, ModConfigViewModel modConfig);
    }
}
