﻿using System;

namespace KotorAutoMod
{
    public class Mod
    {
        public Mod(
            string listName,
            string author,
            string[] type,
            string importance,
            string[] modFileName,
            string instructionsName,
            string description,
            Uri[] modPage,
            string additionalInstructions = ""
            )
        {
            ListName = listName;
            Author = author;
            Type = type;
            Importance = importance;
            ModFileName = modFileName;
            InstructionsName = instructionsName;
            Description = description;
            ModPage = modPage;
            AdditionalInformation = additionalInstructions;
        }
        public string ListName { get; set; }

        public string Author { get; set; }

        public string[] Type { get; set; }

        public string Importance { get; set; }

        public string[] ModFileName { get; set; }

        public string InstructionsName { get; set; }

        public string Description { get; set; }

        public Uri[] ModPage { get; set; }

        public string AdditionalInformation { get; set; }

        public bool isChecked { get; set; } = true;

        public bool isAvailable { get; set; } = false;
    }
}
