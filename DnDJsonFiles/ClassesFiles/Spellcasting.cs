using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class Spellcasting
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("spellcasting_ability")]
        public APIReference SpellcastingAbility { get; set; }

        [JsonProperty("info")]
        public List<Info> Info = new List<Info>();
    }
}
