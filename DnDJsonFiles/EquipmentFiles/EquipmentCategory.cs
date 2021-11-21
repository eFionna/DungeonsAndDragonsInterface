using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class EquipmentCategory : APIReference
    {
        [JsonProperty("equipment")]
        public List<APIReference> Equipment = new();
    }
}
