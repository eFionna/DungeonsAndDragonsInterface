using DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Action
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("damage")]
        public List<Damage> Damage = new List<Damage>();

        [JsonProperty("attack_bonus")]
        public int AttackBonus { get; set; }

        [JsonProperty("dc")]
        public Dc Dc { get; set; }

        [JsonProperty("usage")]
        public Usage Usage { get; set; }
    }

}
