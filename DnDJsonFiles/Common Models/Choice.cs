using DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models
{
    public class Choice
    {
        [JsonProperty("choose")]
        public int Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public FromEquipment From { get; set; }
    }
}
