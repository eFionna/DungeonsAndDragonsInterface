using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Proficiency
    {
        [JsonProperty("value")]
        public int Value { get; set; }

#pragma warning disable IDE1006 // Naming Styles
        [JsonProperty("proficiency")]
        public APIReference _Proficiency { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
