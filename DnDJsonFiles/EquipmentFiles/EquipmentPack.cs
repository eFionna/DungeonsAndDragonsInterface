using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class EquipmentPack : APIReference
    {
        [JsonProperty("equipment_category")]
        public APIReference EquipmentCategory { get; set; }
        [JsonProperty("gear_category")]
        public APIReference GearCategory { get; set; }
        [JsonProperty("cost")]
        public Cost Cost { get; set; }
        [JsonProperty("contents")]
        public List<APIReference> Contents = new List<APIReference>();
    }
}
