using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class LevelsForClass
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("ability_score_bonuses")]
        public int AbilityScoreBonuses { get; set; }

        [JsonProperty("prof_bonus")]
        public int ProfBonus { get; set; }

        [JsonProperty("feature_choices")]
        public List<APIReference> FeatureChoices = new();

        [JsonProperty("features")]
        public List<APIReference> Features = new();

        [JsonProperty("spellcasting")]
        public SpellSlotsPerLevel SpellSlotsPerLevel { get; set; }

        [JsonProperty("class_specific")]
        public ClassSpecific ClassSpecific { get; set; }

        [JsonProperty("class")]
        public APIReference Class { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("subclass_specific")]
        public SubclassSpecific SubclassSpecific { get; set; }

        [JsonProperty("subclass")]
        public APIReference Subclass { get; set; }
    }

}
