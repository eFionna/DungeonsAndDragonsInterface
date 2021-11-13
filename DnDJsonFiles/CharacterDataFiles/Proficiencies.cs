using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.CharacterDataFiles
{
    public class Proficiencies : APIReference
    {
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("classes")]
        public List<APIReference> Classes = new List<APIReference>();
        [JsonProperty("races")]
        public List<APIReference> Races = new List<APIReference>();
        [JsonProperty("references")]
        public List<APIReference> EquipmentCategories = new List<APIReference>();
    }
}
