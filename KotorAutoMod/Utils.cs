using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal static class Utils
    {
        public static ObservableCollection<Mod> InitializeModList()
        {
            ObservableCollection<Mod> modList = new ObservableCollection<Mod>();

            string? outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string[] files = Directory.GetFiles(Path.Combine(outputDirectory, "resources"));

            foreach(string file in files)
            {
                modList.Add(new Mod(getModName(file)));
            }

            return modList;
        }

        /*
         * Extracts name of mod from full filepath
         */
        private static string getModName(string filePath)
        {
            string fileNameWithExtension = filePath.Split(Path.DirectorySeparatorChar).Last();
            return fileNameWithExtension.Split(".").First();
        }
    }
}
