using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Equipment : Item
    {
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [JsonProperty("cost")]
        public Cost Cost { get; set; }
        [JsonProperty("equipment_category")]
        public EquipmentCategory EquipmentCategory { get; set; }
    }
}
