using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.SpellsFiles
{
    public class Spell : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Description = new List<string>();

        [JsonProperty("higher_level")]
        public List<string> HigherLevel { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("components")]
        public List<string> Components { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("ritual")]
        public bool? Ritual { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("concentration")]
        public bool? Concentration { get; set; }

        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }

        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        [JsonProperty("damage")]
        public SpellDamage Damage { get; set; }

        [JsonProperty("school")]
        public APIReference School { get; set; }

        [JsonProperty("classes")]
        public List<APIReference> Classes = new List<APIReference>();

        [JsonProperty("subclasses")]
        public List<APIReference> Subclasses = new List<APIReference>();
    }
}
