using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.CharacterDataFiles
{
    public class AbilityScores : APIReference
    {
        [JsonProperty("full_name")]
        public String FullName { get; set; }
        [JsonProperty("desc")]
        public List<string> Descriptions = new List<string>();
        [JsonProperty("skills")]
        public List<APIReference> Skills = new List<APIReference>();
    }
}
