using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.SpellsFiles
{
    public class SpellDamage : APIReference
    {
        [JsonProperty("damage_type")]
        public APIReference DamageType { get; set; }

        [JsonProperty("damage_at_slot_level")]
        public DamageAtSlotLevel DamageAtSlotLevel { get; set; }
    }
}
