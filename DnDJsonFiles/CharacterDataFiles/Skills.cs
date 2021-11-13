using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.CharacterDataFiles
{
    public class Skills : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Descriptions = new List<string>();
        [JsonProperty("ability_score")]
        public APIReference AbilityScore { get; set; }
    }
}
