using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Tool : Gear
    {
        [JsonProperty("tool_category")]
        public string ToolCategory { get; set; }
    }
}
