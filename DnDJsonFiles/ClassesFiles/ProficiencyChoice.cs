using Newtonsoft.Json;
using System.Collections.Generic;
using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class ProficiencyChoice
    {
        [JsonProperty("choose")]
        public int Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public List<APIReference> From { get; set; }
    }
}
