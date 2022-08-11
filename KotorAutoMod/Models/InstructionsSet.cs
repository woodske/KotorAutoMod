using System;

namespace KotorAutoMod.Models
{
    class InstructionsSet
    {
        public String InstructionSetName { get; set; }

        public Uri InstructionsSetUri { get; set; }

        public InstructionsSet(string instructionsSetName, Uri instructionsSetUri)
        {
            InstructionSetName = instructionsSetName;
            InstructionsSetUri = instructionsSetUri;
        }
    }
}
