using Newtonsoft.Json;
using System.Collections.Generic;


namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class StartingEquipmentOptions
    {
        [JsonProperty("starting_equipment_options")]
        public List<StartingEquipmentOption> StartingEquipmentoptions { get; set; }
    }
}
