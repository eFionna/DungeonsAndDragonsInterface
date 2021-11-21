using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
    public class Weapon : Equipment
    {
        [JsonProperty("weapon_category")]
        public string WeaponCategory { get; set; }
        [JsonProperty("weapon_range")]
        public string WeaponRange { get; set; }
        [JsonProperty("category_range")]
        public string CategoryRange { get; set; }
        [JsonProperty("damage")]
        public Damage Damage { get; set; }
        [JsonProperty("two_handed_damage")]
        public TwoHandedDamage TwoHandedDamage { get; set; }
        [JsonProperty("range")]
        public Range Range { get; set; }
        [JsonProperty("properties")]
        public List<APIReference> Properties = new();
    }
}
