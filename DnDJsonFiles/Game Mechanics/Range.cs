using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics
{
    public class Range
    {
        [JsonProperty("normal")]
        public int Normal { get; set; }

        [JsonProperty("long")]
        public long Long { get; set; }
    }    
}
