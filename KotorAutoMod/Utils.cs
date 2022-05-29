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

namespace KotorAutoMod
{
    internal static class Utils
    {
        public static ObservableCollection<Mod> InitializeModList()
        {
            ObservableCollection<Mod> modList = new ObservableCollection<Mod>();

            string[] files = Directory.GetFiles(getZippedModsFolderPath());

            foreach (string file in files)
            {
                modList.Add(new Mod(Path.GetFileNameWithoutExtension(file)));
            }

            return modList;
        }

        private static string getZippedModsFolderPath()
        {
            string? outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return Path.Combine(outputDirectory, "resources");
        }

        public static void unzipMods(ObservableCollection<Mod> selectedModsList, string outputPath)
        {
            string[] files = Directory.GetFiles(getZippedModsFolderPath());

            foreach (string file in files)
            {
                if (selectedModsList.Any(mod => mod.Name.Equals(Path.GetFileNameWithoutExtension(file))))
                {
                    string fileExtension = Path.GetExtension(file);
                    string unzipPath = Path.Combine(outputPath, Path.GetFileNameWithoutExtension(file));
                    Directory.CreateDirectory(unzipPath);

                    switch (fileExtension)
                    {
                        case ".7z":                      
                            using (var archive = SevenZipArchive.Open(file))
                            {
                                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                                {
                                    entry.WriteToDirectory(unzipPath, new ExtractionOptions()
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
                                        reader.WriteEntryToDirectory(unzipPath, new ExtractionOptions()
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
    }
}
