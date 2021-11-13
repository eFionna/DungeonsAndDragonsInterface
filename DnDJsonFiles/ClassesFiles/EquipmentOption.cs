using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class EquipmentOption
    {
        [JsonProperty("choose")]
        public int Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public FromEquipmentCategory From { get; set; }

    }
}
