using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;
using KotorAutoMod.ViewModels;
using KotorAutoMod.Models;
using KotorAutoMod.Instructions;
using SevenZipExtractor;

namespace KotorAutoMod
{
    internal static class Utils
    {
        public static string[] supportedCompressedFileExtensions = new string[] { ".7z", ".zip", ".rar" };
        /*
         * Extracts compressed mods. The extract folder will have the same name and live in the same folder as the compressed mods.
         */
        public static async Task extractMods(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            int modCount = 1;
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

                    modConfig.updateTaskProgress($"Extracting {modCount}/{selectedMods.Count()}: {Path.GetFileName(modFile)}");
                    Debug.WriteLine($"Extracting {Path.GetFileNameWithoutExtension(modFile)}");

                    await Task.Run(() =>
                    {
                        using (ArchiveFile archiveFile = new ArchiveFile(modPath))
                        {
                            archiveFile.Extract(extractDirectory);
                        }
                    });
                }
                modCount++;
            }

            Debug.WriteLine("All done extracting mods");
        }

        /*
         * Gets directory for files in the Resources folder
         */
        public static string getResourcesDirectory()
        {
            string? outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.Combine(outputDirectory, "Resources");
        }

        /*
         * Extracts compressed files from the Resource directory
         */
        public static void extractSetupTools()
        {
            string[] compressedSetupTools = Directory.GetFiles(getResourcesDirectory());

            foreach (string compressedSetupTool in compressedSetupTools)
            {
                string extractDirectory = Path.Combine(getResourcesDirectory(), Path.GetFileNameWithoutExtension(compressedSetupTool));
                Directory.CreateDirectory(extractDirectory);

                using (ArchiveFile archiveFile = new ArchiveFile(compressedSetupTool))
                {
                    archiveFile.Extract(extractDirectory);
                }
            }
        }

        /*
         * Initializes mod list and sets checked and isAvailable based on if the compressed mods are present
         */
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

                ModViewModel modViewModel = new ModViewModel(supportedMod);
                modViewModel.isAvailable = hasAllModFiles;
                modViewModel.isChecked = hasAllModFiles;

                // Default mod to unchecked
                if (supportedMod.ListName == "Larger Text Fonts")
                {
                    supportedMod.isChecked = false;
                }

                mods.Add(modViewModel);
            }

            return mods;
        }

        /*
         * Util for mods that just need to copy files to override
         */
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

        /*
         * Util for mods that just need to copy files to movies
         */
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

        /*
         * Runs executables, primarily TSLPatcher
         */
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

        /*
         * Determines the progress bar maximum value. This may be tweaked in the applyMods function.
         */
        public static int getProgressBarMaximum(ModConfigViewModel modConfig, IEnumerable<ModViewModel> selectedMods)
        {
            int maximum = 0;

            // Extract setup tool + 2 setup mods
            if (modConfig.FirstTimeSetupIsChecked) maximum += 3;

            // One tick for unzipping and 1 tick for applying mod
            maximum += selectedMods.Count() * 2;

            return maximum + 1;
        }

        /* 
         * Extract mods and run the instructions for selected mods
         */
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

                modConfig.updateTaskProgress("Applying 4 GB patch");
                await new Four_GB_Patch_Instructions().applyMod(new List<string> { Path.Combine(Utils.getResourcesDirectory(), "4gb_patch") }, modConfig, null);
            }

            modConfig.Instructions = "Extracting mods... this may take a few minutes.";
            await Utils.extractMods(modConfig, selectedMods);
            int modCount = 1;

            foreach (ModViewModel selectedMod in selectedMods)
            {
                List<string> readyMods = new List<string>();
                foreach (string modFileName in selectedMod.ModFileName)
                {
                    // Some mods have single file downloads, add them here.
                    string[] singleFileMods = new string[] { "dan14_sherruk.utc", "dan13_zzshari.utc", "N_DarthMalak01.tga", "P_MissionH01.txi", "P_CandBB01.txi", "tar02_duelorg021.dlg" };
                    if (singleFileMods.Any(singleFileMod => singleFileMod.Contains(modFileName)))
                    {
                        readyMods.Add(Path.Combine(modConfig.ModsDirectory, Path.GetFileName(modFileName)));

                        // Mods with multiple downloads that include a single file and folder should not decrement the progress bar max
                        string[] singleFileModsWithFolders = new string[] { "N_DarthMalak01.tga", "P_MissionH01.txi", "P_CandBB01.txi" };
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

                modConfig.updateTaskProgress($"Applying mod {modCount}/{selectedMods.Count()}: {selectedMod.ListName}");

                // Invoke the 'applyMod' method in the appropriate instruction class
                var type = Type.GetType(className);
                var applyMod = type.GetMethod("applyMod");
                var classInstance = Activator.CreateInstance(type);
                object[] parameters = new object[] { readyMods, modConfig, selectedMod };
                await (Task)applyMod.Invoke(classInstance, parameters);
                modCount++;
            }
        }

        /* 
         * Opens direct download link in browser for given mods
         */
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

        /*
         * Basic instructions for mods that use TSLPatcher
         */
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

        /*
         * Basic instructions for mods that move files to override
         */
        public static void copyFilesToOverrideInstructions(ModConfigViewModel modConfig, ModViewModel mod)
        {
            string message = $"Copying files from {mod.ListName} to the Override folder.\n" +
                "No actions needed";

            modConfig.Instructions = message;
        }

        /*
         * Opens URL, used for mods that require a choice
         */
        public static void openUrl(Uri uri)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.FileName = uri.AbsoluteUri;
            Process.Start(startInfo);
        }

        /*
         * Filter mods based on filter options in the WPF app
         */
        public static IEnumerable<ModViewModel> filterMods(IEnumerable<ModViewModel> mods, ModConfigViewModel modConfig)
        {
            // type filter
            IEnumerable<ModViewModel> typeFilteredMods = !string.IsNullOrEmpty(modConfig.SelectedType) ?
                mods.Where(mod => mod.Type == modConfig.SelectedType) :
                mods;

            // importance filter
            IEnumerable<ModViewModel> importanceFilteredMods = !string.IsNullOrEmpty(modConfig.SelectedImportanceTier) ?
                typeFilteredMods.Where(mod => mod.Importance == modConfig.SelectedImportanceTier) :
                typeFilteredMods;

            // search filter
            IEnumerable<ModViewModel> searchFilteredMods = !string.IsNullOrEmpty(modConfig.SearchText) ?
                importanceFilteredMods.Where(mod =>
                {
                    return
                        mod.ListName.ToLower().Contains(modConfig.SearchText.ToLower()) ||
                        mod.Author.ToLower().Contains(modConfig.SearchText.ToLower()) ||
                        mod.Description.ToLower().Contains(modConfig.SearchText.ToLower());
                }) :
                importanceFilteredMods;

            return searchFilteredMods;
        }
    }
}
