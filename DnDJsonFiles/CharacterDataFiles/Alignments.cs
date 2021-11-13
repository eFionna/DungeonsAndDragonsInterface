using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.CharacterDataFiles
{
    public class Alignments : APIReference
    {
        [JsonProperty("abbreviation")]
        public String Abbreviation { get; set; }
        [JsonProperty("desc")]
        public List<string> Descriptions = new List<string>();
    }
}
