using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.RacesFiles
{
    public class Races : APIReference
    {
        [JsonProperty("speed")]
        public int Speed { get; set; }
        [JsonProperty("ability_bonuses")]
        public List<AbilityBonus> AbilityBonuses = new List<AbilityBonus>();
        [JsonProperty("alignment")]
        public string Alignment { get; set; }
        [JsonProperty("age")]
        public string Age { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("size_description")]
        public string SizeDescription { get; set; }
        [JsonProperty("starting_proficiencies")]
        public List<APIReference> StartingProficiencies = new List<APIReference>();
        [JsonProperty("languages")]
        public List<APIReference> Languages = new List<APIReference>();
        [JsonProperty("language_desc")]
        public string LanguageDescdescription { get; set; }
        [JsonProperty("traits")]
        public List<APIReference> Traits = new List<APIReference>();
        [JsonProperty("subraces")]
        public APIReference Subraces { get; set; }
    }
}
