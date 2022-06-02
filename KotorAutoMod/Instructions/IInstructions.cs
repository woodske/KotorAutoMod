using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal interface IInstructions
    {
        public Task applyMod(string modDirectory, ModConfig modConfig, FormActions formActions);
    }
}
