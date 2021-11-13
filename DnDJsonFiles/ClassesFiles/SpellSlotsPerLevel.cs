using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class SpellSlotsPerLevel
    {
        [JsonProperty("cantrips_known")]
        public int CantripsKnown { get; set; }

        [JsonProperty("spells_known")]
        public int SpellsKnown { get; set; }

        [JsonProperty("spell_slots_level_1")]
        public int SpellSlotsLevel1 { get; set; }

        [JsonProperty("spell_slots_level_2")]
        public int SpellSlotsLevel2 { get; set; }

        [JsonProperty("spell_slots_level_3")]
        public int SpellSlotsLevel3 { get; set; }

        [JsonProperty("spell_slots_level_4")]
        public int SpellSlotsLevel4 { get; set; }

        [JsonProperty("spell_slots_level_5")]
        public int SpellSlotsLevel5 { get; set; }

        [JsonProperty("spell_slots_level_6")]
        public int SpellSlotsLevel6 { get; set; }

        [JsonProperty("spell_slots_level_7")]
        public int SpellSlotsLevel7 { get; set; }

        [JsonProperty("spell_slots_level_8")]
        public int SpellSlotsLevel8 { get; set; }

        [JsonProperty("spell_slots_level_9")]
        public int SpellSlotsLevel9 { get; set; }
    }
}
