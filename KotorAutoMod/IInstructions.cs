using System;

namespace KotorAutoMod
{
    internal interface IInstructions
    {
        void applyMod(string modDirectory, ModConfig modConfig, FormActions formActions);
    }
}
