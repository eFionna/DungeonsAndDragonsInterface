using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles
{
    public class GETReults
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<APIReference> Results = new();
    }
}
