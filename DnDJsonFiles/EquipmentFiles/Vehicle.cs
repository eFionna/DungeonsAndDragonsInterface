using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Vehicle : Equipment
    {
        [JsonProperty("vehicle_category")]
        public string VehicleCategory { get; set; }
    }
}
