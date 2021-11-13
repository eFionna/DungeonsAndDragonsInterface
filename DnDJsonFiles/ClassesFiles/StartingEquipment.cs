using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class StartingEquipment
    {
        [JsonProperty("equipment")]
        public APIReference Equipment;

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
