using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class Features : APIReference
    {
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("class")]
        public APIReference Classe { get; set; }
        [JsonProperty("subclass")]
        public APIReference Subclass { get; set; }
        [JsonProperty("desc")]
        public List<string> Description = new();
    }
}
