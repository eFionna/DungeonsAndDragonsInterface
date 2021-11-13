using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models
{
    class BackgroundFeature
    {
        [JsonProperty("desc")]
        public List<string> Descriptions = new List<string>();
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}
