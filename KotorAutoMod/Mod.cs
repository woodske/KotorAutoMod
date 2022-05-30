using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorAutoMod
{
    internal class Mod
    {
        public Mod(string listName, string modFileName, string instructionsName, string description, Uri downloadLink, Uri modPage)
        {
            ListName = listName;
            ModFileName = modFileName;
            InstructionsName = instructionsName;
            Description = description;
            DownloadLink = downloadLink;
            ModPage = modPage;
        }
        public string ListName { get; set; }

        public string ModFileName { get; set; }

        public string InstructionsName { get; set; }

        public string Description { get; set; }

        public Uri DownloadLink { get; set; }

        public Uri ModPage { get; set; }

        public bool isChecked { get; set; } = true;

    }
}
