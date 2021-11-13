using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models
{
    public class AbilityBonus
    {
        [JsonProperty("bonus")]
        public int Bonus { get; set; }
        [JsonProperty("ability_score")]
        public APIReference AbilityScore { get; set; }
    }
}
