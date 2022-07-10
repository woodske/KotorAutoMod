using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_Taris_Reskin_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            //Don't install the included modifications to the Dantooine Estates or Sith Base.
            //You will additionally need to delete the following files before moving the mod content to the override folder: LTS_Bsky01.tga, LTS_Bsky02.tga, and (sorted by name) LTS_sky0001.tga through LTS_SKY0005.tga
            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            List<string> excludeList = new List<string>()
            {
                "LTS_Bsky01.tga",
                "LTS_Bsky02.tga",
                "LTS_sky0001.tga",
                "LTS_Sky0001Fix.tga",
                "LTS_sky0002.tga",
                "LTS_sky0003.tga",
                "LTS_SKY0004.tga",
                "LTS_SKY0004Fix.tga",
                "LTS_SKY0005.tga"
            };
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Taris_Reskin", "Taris_TexturePack", "Taris_Tex_Part1"), modConfig.SwkotorDirectory, excludeList);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], "Taris_Reskin", "Taris_TexturePack", "Taris_Tex_Part2"), modConfig.SwkotorDirectory);
        }
    }
}
