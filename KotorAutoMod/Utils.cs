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
        public static async Task extractMods(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            string[] files = Directory.GetFiles(modConfig.CompressedModsDirectory);

            foreach (string file in files)
            {
                if (selectedMods.Any(mod => mod.ModFileName.Equals(Path.GetFileName(file)) && mod.isChecked))
                {
                    string fileExtension = Path.GetExtension(file);
                    string extractDirectory = Path.Combine(modConfig.CompressedModsDirectory, Path.GetFileNameWithoutExtension(file));
                    Directory.CreateDirectory(extractDirectory);

                    modConfig.updateTaskProgress($"Extracting {Path.GetFileNameWithoutExtension(file)}");
                    Debug.WriteLine($"Extracting {Path.GetFileNameWithoutExtension(file)}");

                    await Task.Run(() =>
                    {
                        switch (fileExtension)
                        {
                            case ".7z":
                                using (var archive = SevenZipArchive.Open(file))
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
                                using (Stream stream = File.OpenRead(file))
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

        public static ObservableCollection<ModViewModel> getMods(string compressedModsDirectory)
        {
            ObservableCollection<ModViewModel> mods = new ObservableCollection<ModViewModel>();

            List<string> compressedModsList = Directory.GetFiles(compressedModsDirectory).ToList();

            foreach (Mod supportedMod in SupportedMods.supportedMods())
            {
                ModViewModel modViewModel = new ModViewModel(supportedMod);
                if (compressedModsList.Any(compressedModPath => Path.GetFileName(compressedModPath) == supportedMod.ModFileName))
                {
                    modViewModel.isAvailable = true;
                }
                else
                {
                    modViewModel.isAvailable = false;
                }

                mods.Add(modViewModel);
            }

            return mods;
        }

        public async static Task moveAllToOverrideDirectory(string modDirectory, string swkotorDirectory, List<string>? excludeList = null)
        {
            List<string> modFiles = Directory.GetFiles(modDirectory).ToList();
            string overrideDirectory = Path.Combine(swkotorDirectory, "Override");

            await Task.Run(() =>
            {
                foreach (string modFile in modFiles)
                {
                    if (excludeList == null || !excludeList.Contains(Path.GetFileName(modFile)))
                    {
                        File.Copy(modFile, Path.Combine(overrideDirectory, Path.GetFileName(modFile)), true);
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
                await new KOTOR_Editable_Executable_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "KOTOR Editable Executable"), modConfig);

                modConfig.updateTaskProgress("Applying Universal Widescreen patcher");
                await new UniWS_Patcher_Instructions().applyMod(Path.Combine(Utils.getResourcesDirectory(), "uniws"), modConfig);

                //FileUnblocker fileUnblocker = new FileUnblocker();
                //fileUnblocker.Unblock(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch", "4gb_patch.exe"));
                // Four_GB_Patch_Instructions.applyMod(Path.Combine(Utils.getResourcesDirectory(), "4gb_patch"), modConfig, instructionsTextBlock);
            }

            await Utils.extractMods(modConfig, selectedMods);

            foreach (Mod supportedMod in SupportedMods.supportedMods())
            {
                if (selectedMods.Any(selectedMod => selectedMod.ListName == supportedMod.ListName && selectedMod.isChecked))
                {
                    string modDirectory = Path.Combine(modConfig.CompressedModsDirectory, Path.GetFileNameWithoutExtension(supportedMod.ModFileName));
                    string className = $"KotorAutoMod.Instructions.{supportedMod.InstructionsName}";

                    modConfig.updateTaskProgress($"Applying mod: {supportedMod.ListName}");

                    // Invoke the 'applyMod' method in the appropriate instruction class
                    var type = Type.GetType(className);
                    var applyMod = type.GetMethod("applyMod");
                    var classInstance = Activator.CreateInstance(type);
                    object[] parameters = new object[] { modDirectory, modConfig };
                    await (Task)applyMod.Invoke(classInstance, parameters);
                }
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
    }
}
