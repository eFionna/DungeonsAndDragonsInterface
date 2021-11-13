using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Usage
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("times")]
        public int Times { get; set; }

        [JsonProperty("dice")]
        public string Dice { get; set; }

        [JsonProperty("min_value")]
        public int MinValue { get; set; }
    }
}
