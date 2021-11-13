using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Senses
    {
        [JsonProperty("blindsight")]
        public string Blindsight { get; set; }

        [JsonProperty("darkvision")]
        public string Darkvision { get; set; }

        [JsonProperty("passive_perception")]
        public int PassivePerception { get; set; }
    }
}
