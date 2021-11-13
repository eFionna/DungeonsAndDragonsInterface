using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.RacesFiles
{
    public class Traits
    {
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("races")]
        public List<APIReference> Races = new List<APIReference>();
        [JsonProperty("subraces")]
        public List<APIReference> Subraces = new List<APIReference>();
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("desc")]
        public List<string> Description = new List<string>();
        [JsonProperty("proficiencies")]
        public List<APIReference> Proficiencies = new List<APIReference>();
        [JsonProperty("proficiency_choices")]
        public List<Choice> ProficiencyChoices = new List<Choice>();
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}
