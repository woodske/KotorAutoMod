using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class Reddit_High_Quality_Blasters_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // After the install has completed, delete the following files from your override directory: w_ionrfl_04.mdl, w_ionrfl_04.mdx, w_rptnblstr_004.mdl, w_rptnblstr_004.mdx, w_blstrpstl_006.mdl and w_blstrpstl_006.mdx
            string TSLPatcherPath = Path.Combine(readyMods[0], "High Quality Blasters 1.1", "High Quality Blasters Installer");
            if (modConfig.UseAuto)
            {
                Utils.tslPatcherCLIInstructions(modConfig, mod);
                await Utils.runTSLPatcherCLI(modConfig, TSLPatcherPath);
            }
            else
            {
                Utils.tslPatcherInstructions(modConfig, mod);
                await Utils.runExecutable(TSLPatcherPath);
            }

            string[] filesToDelete = new string[]
            {
                "w_ionrfl_04.mdl",
                "w_ionrfl_04.mdx",
                "w_rptnblstr_004.mdl",
                "w_rptnblstr_004.mdx",
                "w_blstrpstl_006.mdl",
                "w_blstrpstl_006.mdx"
            };

            await Utils.deleteFromOverride(modConfig, filesToDelete);
        }
    }
}
