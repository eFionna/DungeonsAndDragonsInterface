using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.BackgroundFiles
{
    public class Backgrounds : APIReference
    {
        [JsonProperty("starting_proficiencies")]
        public List<APIReference> StartingProficiencies = new List<APIReference>();
        [JsonProperty("languages")]
        public List<APIReference> Languages = new List<APIReference>();
        [JsonProperty("starting_equipment")]
        public List<APIReference> StartingEquipment = new List<APIReference>();
        [JsonProperty("starting_equipment_options")]
        public List<Choice> StartingEquipmentOptions = new List<Choice>();
        [JsonProperty("feature")]
        public BackgroundFeature Feature { get; set; }
        [JsonProperty("personality_traits")]
        public Choice PersonalityTraits { get; set; }
        [JsonProperty("ideals")]
        public Choice Ideals { get; set; }
        [JsonProperty("bonds")]
        public Choice Bonds { get; set; }
        [JsonProperty("flaws")]
        public Choice Flaws { get; set; }
    }
}
