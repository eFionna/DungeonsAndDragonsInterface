using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class WeaponProperties : APIReference
    {
        [JsonProperty("desc")]
        public List<string> Description = new();
    }
}
