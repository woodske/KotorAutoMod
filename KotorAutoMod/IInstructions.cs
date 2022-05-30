using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod
{
    internal interface IInstructions
    {
        static void applyMod(string modDirectory, ModConfig modConfig, Window window) => throw new NotImplementedException();
    }
}
