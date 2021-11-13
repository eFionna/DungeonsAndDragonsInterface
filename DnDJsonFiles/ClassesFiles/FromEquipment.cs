using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class FromEquipment : APIReference
    {
        [JsonProperty("equipment_category")]
        public APIReference EquipmentCategory { get; set; }

        [JsonProperty("equipment")]
        public APIReference Equipment { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("equipment_option")]
        public Choice EquipmentOption { get; set; }
    }
}
