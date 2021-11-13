using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.CharacterDataFiles
{
    public class Languages : APIReference
    {
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("typical_speakers")]
        public List<string> TypicalSpeakers = new List<string>();
        [JsonProperty("script")]
        public String Script { get; set; }
    }
}
