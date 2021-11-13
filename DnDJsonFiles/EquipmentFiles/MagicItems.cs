using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class MagicItems : APIReference
    {
        [JsonProperty("equipment_category")]
        public APIReference EquipmentCategory { get; set; }

        [JsonProperty("desc")]
        public List<string> Description = new List<string>();
    }
}
