using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class EquipmentPack : Equipment
    {
        [JsonProperty("gear_category")]
        public APIReference GearCategory { get; set; }
        [JsonProperty("contents")]
        public List<APIReference> Contents = new();
    }
}
