using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class SpecialAbility
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("usage")]
        public Usage Usage { get; set; }
    }
}
