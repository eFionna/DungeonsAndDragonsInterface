using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class FromEquipmentCategory
    {
        [JsonProperty("equipment_category")]
        public APIReference EquipmentCategory { get; set; }
    }
}
