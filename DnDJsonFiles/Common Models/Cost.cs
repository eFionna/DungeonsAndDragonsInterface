using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models
{
    public class Cost
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
