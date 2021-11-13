using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics
{
    public class Speed
    {
        [JsonProperty("walk")]
        public string Walk { get; set; }

        [JsonProperty("fly")]
        public string Fly { get; set; }

        [JsonProperty("swim")]
        public string Swim { get; set; }
    }
}
