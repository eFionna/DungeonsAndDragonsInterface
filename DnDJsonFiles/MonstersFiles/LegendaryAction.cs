using DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class LegendaryAction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("dc")]
        public Dc Dc { get; set; }

        [JsonProperty("damage")]
        public List<Damage> Damage { get; set; }
    }
}
