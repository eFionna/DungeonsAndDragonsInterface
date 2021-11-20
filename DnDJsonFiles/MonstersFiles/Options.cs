using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Options
    {
        [JsonProperty("choose")]
        public int Choose { get; set; }

        [JsonProperty("from")]
        public List<List<Option>> From = new();
    }
    public class Option
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
