﻿using KotorAutoMod.Models;
using System;
using System.Collections.Generic;

namespace KotorAutoMod.SupportedMods
{
    internal static class Common
    {
        public const string Reddit = "Reddit KOTOR 1 Full Build";
        public const string Stellar = "StellarExile KOTOR 1";

        private static List<InstructionsSet> InstructionsSet = new List<InstructionsSet> {
            new InstructionsSet(Reddit, new Uri("https://www.nexusmods.com/kotor/mods/1463")),
            new InstructionsSet(Stellar, new Uri("https://old.reddit.com/r/kotor/wiki/kotormodbuildfull"))
        };

        public static List<InstructionsSet> getInstructionsSet()
        {
            return InstructionsSet;
        }      
    }
}
