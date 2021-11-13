using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Gear : Equipment
    {
        [JsonProperty("gear_category")]
        public APIReference GearCategory { get; set; }
    }
}
