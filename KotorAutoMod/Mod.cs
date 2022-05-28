using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal class Mod
    {
        public Mod(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public bool isChecked { get; set; } = true;

    }
}
