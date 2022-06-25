using SharpCompress.Archives.SevenZip;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using SharpCompress.Readers;
using System.Diagnostics;
using KotorAutoMod.ViewModels;
using KotorAutoMod.Models;
using KotorAutoMod.Instructions;

namespace KotorAutoMod
{
    internal static class Utils
    {
        public static string[] supportedCompressedFileExtensions = new string[] { ".7z", ".zip", ".rar" };
        public static async Task extractMods(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            foreach (ModViewModel selectedMod in selectedMods)
            {
                foreach (string modFile in selectedMod.ModFileName)
                {
                    string fileExtension = Path.GetExtension(modFile);
                    if (!supportedCompressedFileExtensions.Contains(fileExtension))
                    {
                        break;
                    }
                    string extractDirectory = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(modFile));
                    string modPath = Path.Combine(modConfig.ModsDirectory, Path.GetFileName(modFile));
                    Directory.CreateDirectory(extractDirectory);

                    modConfig.updateTaskProgress($"Extracting {Path.GetFileNameWithoutExtension(modFile)}");
                    Debug.WriteLine($"Extracting {Path.GetFileNameWithoutExtension(modFile)}");

                    await Task.Run(() =>
                    {
                        switch (fileExtension)
                        {
                            case ".7z":
                                using (var archive = SevenZipArchive.Open(modPath))
                                {
                                    var reader = archive.ExtractAllEntries();
                                    while (reader.MoveToNextEntry())
                                    {
                                        if (!reader.Entry.IsDirectory)
                                            reader.WriteEntryToDirectory(extractDirectory, new ExtractionOptions()
                                            {
                                                ExtractFullPath = true,
                                                Overwrite = true
                                            });
                                    }
                                };
                                break;
                            default:
                                using (Stream stream = File.OpenRead(modPath))
                                using (var reader = ReaderFactory.Open(stream))
                                {
                                    while (reader.MoveToNextEntry())
                                    {
                                        if (!reader.Entry.IsDirectory)
                                        {
                                            reader.WriteEntryToDirectory(extractDirectory, new ExtractionOptions()
                                            {
                                                ExtractFullPath = true,
                                                Overwrite = true
                                            });
                                        }
                                    }
                                };
                                break;
                        }
                    });
                }
            }

            Debug.WriteLine("All done extracting mods");
        }

        public static string getResourcesDirectory()
        {
            string? outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(outputDirectory, "Resources");
        }

        public static void extractSetupTools()
        {
            string[] compressedSetupTools = Directory.GetFiles(getResourcesDirectory());

            foreach (string compressedSetupTool in compressedSetupTools)
            {
                string extractDirectory = Path.Combine(getResourcesDirectory(), Path.GetFileNameWithoutExtension(compressedSetupTool));
                Directory.CreateDirectory(extractDirectory);

                using (Stream stream = File.OpenRead(compressedSetupTool))
                using (var reader = ReaderFactory.Open(stream))
                {
                    while (reader.MoveToNextEntry())
                    {
                        if (!reader.Entry.IsDirectory)
                        {
                            reader.WriteEntryToDirectory(extractDirectory, new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                };
            }
        }

        public static ObservableCollection<ModViewModel> getMods(string modsDirectory)
        {
            ObservableCollection<ModViewModel> mods = new ObservableCollection<ModViewModel>();

            List<string> modsList = Directory.GetFiles(modsDirectory).ToList();

            foreach (Mod supportedMod in SupportedMods.supportedMods)
            {
                bool hasAllModFiles = true;
                foreach (string modFile in supportedMod.ModFileName)
                {
                    if (!modsList.Contains(Path.Combine(modsDirectory, modFile)))
                    {
                        hasAllModFiles = false;
                        break;
                    }
                }

                // Default mod to unchecked
                if (supportedMod.ListName == "Larger Text Fonts")
                {
                    supportedMod.isChecked = false;
                }

                ModViewModel modViewModel = new ModViewModel(supportedMod);
                modViewModel.isAvailable = hasAllModFiles;

                mods.Add(modViewModel);
            }

            return mods;
        }

        public async static Task moveAllToOverrideDirectory(string modDirectory, string swkotorDirectory, List<string>? excludeList = null, bool overwrite = true)
        {
            List<string> modFiles = Directory.GetFiles(modDirectory).ToList();
            string overrideDirectory = Path.Combine(swkotorDirectory, "Override");

            await Task.Run(() =>
            {
                foreach (string modFile in modFiles)
                {
                    if (excludeList == null || !excludeList.Contains(Path.GetFileName(modFile)))
                    {
                        try
                        {
                            File.Copy(modFile, Path.Combine(overrideDirectory, Path.GetFileName(modFile)), overwrite);
                        }
                        catch (System.IO.IOException e) { } //Don't throw error if overwrite is false
                    }
                }
            });
        }

        public async static Task moveAllToMoviesDirectory(string modDirectory, string swkotorDirectory, List<string>? excludeList = null, bool overwrite = true)
        {
            List<string> modFiles = Directory.GetFiles(modDirectory).ToList();
            string movieDirectory = Path.Combine(swkotorDirectory, "movies");

            await Task.Run(() =>
            {
                foreach (string modFile in modFiles)
                {
                    if (excludeList == null || !excludeList.Contains(Path.GetFileName(modFile)))
                    {
                        try
                        {
                            File.Copy(modFile, Path.Combine(movieDirectory, Path.GetFileName(modFile)), overwrite);
                        }
                        catch (System.IO.IOException e) { } //Don't throw error if overwrite is false
                    }
                }
            });
        }

        public async static Task runExecutable(string executablePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.FileName = executablePath;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            using (Process exeProcess = Process.Start(startInfo))
            {
                await exeProcess.WaitForExitAsync();
            }
        }

        public static int getProgressBarMaximum(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            int maximum = 0;

            // Extract setup tool + 2 setup mods
            if (modConfig.FirstTimeSetupIsChecked) maximum += 3;

            // One tick for unzipping and 1 tick for applying mod
            maximum += selectedMods.Count() * 2;

            return maximum + 1;
        }

        // Extract mods and run the instructions for selected mods
        public static async Task applyMods(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            // Apply setup tools
            if (modConfig.FirstTimeSetupIsChecked)
            {
                modConfig.updateTaskProgress("Extracting setup tools");
                Utils.extractSetupTools();

                modConfig.updateTaskProgress("Applying KOTOR exe setup tools");
                await new KOTOR_Editable_Executable_Instructions().applyMod(new List<string> { Path.Combine(Utils.getResourcesDirectory(), "KOTOR Editable Executable") }, modConfig, null);

                modConfig.updateTaskProgress("Applying Universal Widescreen patcher");
                await new UniWS_Patcher_Instructions().applyMod(new List<string> { Path.Combine(Utils.getResourcesDirectory(), "uniws") }, modConfig, null);

                //FileUnblocker fileUnblocker = new FileUnblocker();
                //fileUnblocker.Unblock(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch", "4gb_patch.exe"));
                // Four_GB_Patch_Instructions.applyMod(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch"), modConfig, instructionsTextBlock);
            }

            modConfig.Instructions = "Extracting mods... this may take a few minutes.";
            await Utils.extractMods(modConfig, selectedMods);

            foreach (ModViewModel selectedMod in selectedMods)
            {
                List<string> readyMods = new List<string>();
                foreach (string modFileName in selectedMod.ModFileName)
                {
                    // Some mods have single file downloads, add them here.
                    string[] singleFileMods = new string[] { "dan14_sherruk.utc", "dan13_zzshari.utc", "N_DarthMalak01.tga" };
                    if (singleFileMods.Any(singleFileMod => singleFileMod.Contains(modFileName)))
                    {
                        readyMods.Add(Path.Combine(modConfig.ModsDirectory, Path.GetFileName(modFileName)));

                        // Mods with multiple downloads that include a single file and folder should not decrement the progress bar max
                        string[] singleFileModsWithFolders = new string[] { "N_DarthMalak01.tga" };
                        if (!singleFileModsWithFolders.Any(singleFileModWithFolders => singleFileModWithFolders.Contains(modFileName)))
                        {
                            modConfig.ProgressBarMaximum--;
                        }
                    }
                    else
                    {
                        string modFilePath = Path.Combine(modConfig.ModsDirectory, Path.GetFileNameWithoutExtension(modFileName));
                        if (Directory.Exists(modFilePath))
                        {
                            readyMods.Add(modFilePath);
                        }
                        else
                        {
                            readyMods.Add(Path.Combine(modConfig.ModsDirectory, Path.GetFileName(modFileName)));
                        }
                    }
                }

                string className = $"KotorAutoMod.Instructions.{selectedMod.InstructionsName}";

                modConfig.updateTaskProgress($"Applying mod: {selectedMod.ListName}");

                // Invoke the 'applyMod' method in the appropriate instruction class
                var type = Type.GetType(className);
                var applyMod = type.GetMethod("applyMod");
                var classInstance = Activator.CreateInstance(type);
                object[] parameters = new object[] { readyMods, modConfig, selectedMod };
                await (Task)applyMod.Invoke(classInstance, parameters);
            }
        }

        // Opens direct download link in browser for given mods
        public static async Task openModLinks(IEnumerable<ModViewModel> selectedMods)
        {
            foreach (ModViewModel selectedMod in selectedMods)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = selectedMod.ModPage.ToString();
                startInfo.UseShellExecute = true;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    await exeProcess.WaitForExitAsync();
                }
            }
        }

        public static void tslPatcherInstructions(ModConfigViewModel modConfig, ModViewModel mod, string addtionalMessage = "")
        {
            string message = $"Use the TSLPatcher for {mod.ListName}\n\n" +
                $"Click 'Install Mod' and select your swkotor folder\n" +
                modConfig.SwkotorDirectory;

            if (!string.IsNullOrEmpty(addtionalMessage))
            {
                message = message + "\n\n" + addtionalMessage;
            }

            modConfig.Instructions = message;
        }

        public static void copyFilesToOverrideInstructions(ModConfigViewModel modConfig, ModViewModel mod)
        {
            string message = $"Copying files from {mod.ListName} to the Override folder.\n" +
                "No actions needed";

            modConfig.Instructions = message;
        }
    }
}
