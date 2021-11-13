using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using DungeonsAndDragonsInterface.DnDJsonFiles.SpellsFiles;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class Subclasses : APIReference
    {
        [JsonProperty("class")]
        public Class Classe { get; set; }
        [JsonProperty("subclass_flavor")]
        public string SubclassFlavor { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        [JsonProperty("spells")]
        public List<Spell> Spells = new List<Spell>();
        [JsonProperty("subclass_levels")]
        public string SubclassLevels { get; set; }
    }
}
