using Newtonsoft.Json;
using System.Collections.Generic;


namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class StartingEquipmentOption
    {
        [JsonProperty("choose")]
        public int Choose { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("from")]
        public List<EquipmentOptions> From { get; set; }
    }

}
