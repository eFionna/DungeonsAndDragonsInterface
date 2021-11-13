using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.RacesFiles
{
    public class Subraces
    {
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("race")]
        public APIReference Race { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        [JsonProperty("ability_bonuses")]
        public List<AbilityBonus> AbilityBonuses = new List<AbilityBonus>();
        [JsonProperty("starting_proficiencies")]
        public List<APIReference> StartingProficiencies = new List<APIReference>();
        [JsonProperty("languages")]
        public List<APIReference> Languages = new List<APIReference>();
        [JsonProperty("traits")]
        public List<APIReference> Traits = new List<APIReference>();
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}
