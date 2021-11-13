using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.BackgroundFiles
{
    public class BackgroundFeature
    {
        [JsonProperty("desc")]
        public List<string> Desc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
