using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models
{
    public class APIReference
    {
        [JsonProperty("index")]
        public string Index { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
