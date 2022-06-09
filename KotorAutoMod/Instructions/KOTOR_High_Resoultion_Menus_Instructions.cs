using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KotorAutoMod.Instructions
{
    internal class KOTOR_High_Resoultion_Menus_Instructions : IInstructions
    {
        public async Task applyMod(string modDirectory, ModConfigViewModel modConfig)
        {
            // Move the three hires_patcher files to the swkotor folder and run the .bat file.
            // Then move the GUI files corresponding to the monitor's aspect ratio and resolution into the Override folder.
            List<string> filesToMove = new List<string>();
            filesToMove.Add("hires_patcher.bat");
            filesToMove.Add("hires_patcher.exe");
            filesToMove.Add("hires_patcher.pl");

            foreach (string file in filesToMove)
            {
                File.Copy(Path.Combine(modDirectory, file), Path.Combine(modConfig.SwkotorDirectory, file), true);
            }

            //formActions.updateInstructions("Follow bat instructions");

            await Utils.runExecutable(Path.Combine(modConfig.SwkotorDirectory, "hires_patcher.bat"));

            string aspectRatioDirectory;
            string resolutionDirectory = $"gui.{modConfig.SelectedResolution}";

            switch (modConfig.SelectedAspectRatio)
            {
                case ModConfig.four_by_three:
                    aspectRatioDirectory = "4-by-3";
                    break;
                case ModConfig.sixteen_by_nine:
                    aspectRatioDirectory = "16-by-9";
                    break;
                case ModConfig.sixteen_by_ten:
                    aspectRatioDirectory = "16-by-10";
                    break;
                case ModConfig.twentyone_by_nine:
                    aspectRatioDirectory = "21-by-9";
                    break;
                case ModConfig.thirtytwo_by_nine:
                    aspectRatioDirectory = "32-by-9";
                    break;
                default:
                    throw new Exception("Aspect ratio not selected");
            }

            await Utils.moveAllToOverrideDirectory(Path.Combine(modDirectory, aspectRatioDirectory, resolutionDirectory), modConfig.SwkotorDirectory);
        }
    }
}
