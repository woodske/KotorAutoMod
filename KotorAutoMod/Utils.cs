using SharpCompress.Archives;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Readers.Rar;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Readers;
using System.Diagnostics;

namespace KotorAutoMod
{
    internal static class Utils
    {
        public static void unzipMods(ObservableCollection<Mod> modList, string compressedModsDirectory)
        {
            string[] files = Directory.GetFiles(compressedModsDirectory);

            foreach (string file in files)
            {
                if (modList.Any(mod => mod.ModFileName.Equals(Path.GetFileName(file)) && mod.isChecked))
                {
                    string fileExtension = Path.GetExtension(file);
                    string unzipDirectory = Path.Combine(compressedModsDirectory, Path.GetFileNameWithoutExtension(file));
                    Directory.CreateDirectory(unzipDirectory);

                    switch (fileExtension)
                    {
                        case ".7z":                      
                            using (var archive = SevenZipArchive.Open(file))
                            {
                                var reader = archive.ExtractAllEntries();
                                while (reader.MoveToNextEntry())
                                {
                                    if (!reader.Entry.IsDirectory)
                                        reader.WriteEntryToDirectory(unzipDirectory, new ExtractionOptions() 
                                        { 
                                            ExtractFullPath = true, Overwrite = true 
                                        });
                                }
                            };
                            break;
                        default:
                            using (Stream stream = File.OpenRead(file))
                            using (var reader = ReaderFactory.Open(stream))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if (!reader.Entry.IsDirectory)
                                    {
                                        reader.WriteEntryToDirectory(unzipDirectory, new ExtractionOptions()
                                        {
                                            ExtractFullPath = true,
                                            Overwrite = true
                                        });
                                    }
                                }
                            };
                            break;                   
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("All done");
        }

        /*
         * Checks if the compressed mods are available in the selected folder
         */
        public static ObservableCollection<Mod> getAvailableMods(List<Mod> supportedModsList, string compressedModsDirectory)
        {
            List<string> compressedMods = Directory.GetFiles(compressedModsDirectory).ToList();
            ObservableCollection<Mod> availableMods = new ObservableCollection<Mod>();

            foreach (string compressedMod in compressedMods)
            {
                if (supportedModsList.Any(mod => mod.ModFileName == Path.GetFileName(compressedMod)))
                {
                    availableMods.Add(supportedModsList.Single(mod => mod.ModFileName == Path.GetFileName(compressedMod)));
                }     
            }

            return availableMods;
        }

        public static void removeUnzippedFiles(ObservableCollection<Mod> modList)
        {
            //todo: implement method
        }

        public static void moveAllToOverrideDirectory(string modDirectory, string swkotorDirectory, List<string>? excludeList = null)
        {
            List<string> modFiles = Directory.GetFiles(modDirectory).ToList();
            string overrideDirectory = Path.Combine(swkotorDirectory, "Override");

            foreach(string modFile in modFiles)
            {
                if (excludeList == null || !excludeList.Contains(Path.GetFileName(modFile)))
                {
                    File.Copy(modFile, Path.Combine(overrideDirectory, Path.GetFileName(modFile)), true);
                }
            }
        }

        public static void executeInstall(string executablePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.FileName = executablePath;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;


            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
        }

        public static string[] getAvailableScreenResolutionSelections(ModConfig modConfig)
        {
            Dictionary<string, string[]> validScreenResolutions = modConfig.validScreenResolutions;

            if (String.IsNullOrEmpty(modConfig.selectedAspectRatio)) return new string[] { };

            return validScreenResolutions[modConfig.selectedAspectRatio];
        }
    }
}
