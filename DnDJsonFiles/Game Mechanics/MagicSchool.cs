using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics
{
    public class MagicSchool : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Description = new List<string>();
    }
}
