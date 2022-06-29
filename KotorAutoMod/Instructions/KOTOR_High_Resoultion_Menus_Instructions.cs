using KotorAutoMod.Models;
using KotorAutoMod.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace KotorAutoMod.Instructions
{
    internal class KOTOR_High_Resoultion_Menus_Instructions : IInstructions
    {
        public async Task applyMod(List<string> readyMods, ModConfigViewModel modConfig, ModViewModel mod)
        {
            // Move the three hires_patcher files to the swkotor folder and run the .bat file.
            // Then move the GUI files corresponding to the monitor's aspect ratio and resolution into the Override folder.
            List<string> filesToMove = new List<string>();
            filesToMove.Add("hires_patcher.bat");
            filesToMove.Add("hires_patcher.exe");
            filesToMove.Add("hires_patcher.pl");

            foreach (string file in filesToMove)
            {
                File.Copy(Path.Combine(readyMods[0], file), Path.Combine(modConfig.SwkotorDirectory, file), true);
            }

            string width = modConfig.SelectedResolution.Split("x")[0];
            string height = modConfig.SelectedResolution.Split("x")[1];
            modConfig.Instructions =
                "Find the hires_patcher.bat file and run it.\n" +
                //$"Follow bat instructions for {mod.ListName}\n" +
                $"Enter {width} for your width.\n" +
                $"Enter {height} for you height.\n" +
                "Hit Enter when prompted to have the dialog letterbox proportions adjusted\n" +
                "Hit Enter when prompted for the name of the swkotor.exe file\n" +
                "Press any key to exit the script";

            //await Utils.runExecutable(Path.Combine(modConfig.SwkotorDirectory, "hires_patcher.bat"));
            Process.Start("explorer.exe", modConfig.SwkotorDirectory);

            MessageBox.Show("Follow the instructions in the instructions box then press OK when done",
                "KOTOR High Resolution Menus",
                MessageBoxButton.OK
                );

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

            Utils.copyFilesToOverrideInstructions(modConfig, mod);
            await Utils.moveAllToOverrideDirectory(Path.Combine(readyMods[0], aspectRatioDirectory, resolutionDirectory), modConfig.SwkotorDirectory);
        }
    }
}
