using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Gear : Equipment
    {
        [JsonProperty("gear_category")]
        public APIReference GearCategory { get; set; }
        [JsonProperty("desc")]
        public List<string> Description = new();
    }
}
