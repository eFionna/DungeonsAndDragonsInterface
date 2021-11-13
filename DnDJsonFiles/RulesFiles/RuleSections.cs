using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.RulesFiles
{
    public class RuleSections : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Description = new List<string>();
    }
}
