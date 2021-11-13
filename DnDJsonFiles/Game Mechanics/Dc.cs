using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics
{
    public class Dc
    {
        [JsonProperty("dc_type")]
        public APIReference DcType { get; set; }

        [JsonProperty("dc_value")]
        public int DcValue { get; set; }

        [JsonProperty("success_type")]
        public string SuccessType { get; set; }
    }
}
