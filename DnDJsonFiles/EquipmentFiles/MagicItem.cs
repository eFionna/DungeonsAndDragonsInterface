using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class MagicItem : Item
    {
        [JsonProperty("equipment_category")]
        public APIReference EquipmentCategory { get; set; }

        [JsonProperty("desc")]
        public List<string> Description = new();
    }
}
