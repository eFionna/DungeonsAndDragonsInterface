using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Proficiency
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("proficiency")]
        public APIReference _Proficiency { get; set; }
    }
}
