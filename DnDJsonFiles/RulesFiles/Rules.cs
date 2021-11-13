using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.RulesFiles
{
    public class Rules : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Description = new List<string>();
        [JsonProperty("subsections")]
        public List<APIReference> Subsections = new List<APIReference>();
    }
}
