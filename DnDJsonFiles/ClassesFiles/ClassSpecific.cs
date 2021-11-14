using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class ClassSpecific
    {
        [JsonProperty("creating_spell_slots")]
        public List<CreatingSpellSlot> CreatingSpellSlots = new();

        [JsonProperty("rage_count")]
        public int? RageCount { get; set; }

        [JsonProperty("rage_damage_bonus")]
        public int? RageDamageBonus { get; set; }

        [JsonProperty("brutal_critical_dice")]
        public int? BrutalCriticalDice { get; set; }

        [JsonProperty("bardic_inspiration_die")]
        public int? BardicInspirationDie { get; set; }

        [JsonProperty("song_of_rest_die")]
        public int? SongOfRestDie { get; set; }

        [JsonProperty("magical_secrets_max_5")]
        public int? MagicalSecretsMax5 { get; set; }

        [JsonProperty("magical_secrets_max_7")]
        public int? MagicalSecretsMax7 { get; set; }

        [JsonProperty("magical_secrets_max_9")]
        public int? MagicalSecretsMax9 { get; set; }

        [JsonProperty("channel_divinity_charges")]
        public int? ChannelDivinityCharges { get; set; }

        [JsonProperty("destroy_undead_cr")]
        public double? DestroyUndeadCr { get; set; }

        [JsonProperty("wild_shape_max_cr")]
        public double? WildShapeMaxCr { get; set; }

        [JsonProperty("wild_shape_swim")]
        public bool? WildShapeSwim { get; set; }

        [JsonProperty("wild_shape_fly")]
        public bool? WildShapeFly { get; set; }

        [JsonProperty("action_surges")]
        public int? ActionSurges { get; set; }

        [JsonProperty("indomitable_uses")]
        public int? IndomitableUses { get; set; }

        [JsonProperty("extra_attacks")]
        public int? ExtraAttacks { get; set; }

        [JsonProperty("martial_arts")]
        public MartialArts MartialArts { get; set; }

        [JsonProperty("ki_points")]
        public int? KiPoints { get; set; }

        [JsonProperty("unarmored_movement")]
        public int? UnarmoredMovement { get; set; }

        [JsonProperty("aura_range")]
        public int? AuraRange { get; set; }

        [JsonProperty("favored_enemies")]
        public int? FavoredEnemies { get; set; }

        [JsonProperty("favored_terrain")]
        public int? FavoredTerrain { get; set; }

        [JsonProperty("sneak_attack")]
        public SneakAttack SneakAttack { get; set; }

        [JsonProperty("sorcery_points")]
        public int? SorceryPoints { get; set; }

        [JsonProperty("metamagic_known")]
        public int? MetamagicKnown { get; set; }

        [JsonProperty("invocations_known")]
        public int? InvocationsKnown { get; set; }

        [JsonProperty("mystic_arcanum_level_6")]
        public int? MysticArcanumLevel6 { get; set; }

        [JsonProperty("mystic_arcanum_level_7")]
        public int? MysticArcanumLevel7 { get; set; }

        [JsonProperty("mystic_arcanum_level_8")]
        public int? MysticArcanumLevel8 { get; set; }

        [JsonProperty("mystic_arcanum_level_9")]
        public int? MysticArcanumLevel9 { get; set; }
        [JsonProperty("arcane_recovery_levels")]
        public int? ArcaneRecoveryLevels { get; set; }
    }
    public class MartialArts
    {
        [JsonProperty("dice_count")]
        public int DiceCount { get; set; }

        [JsonProperty("dice_value")]
        public int DiceValue { get; set; }
    }
    public class SneakAttack
    {
        [JsonProperty("dice_count")]
        public int DiceCount { get; set; }

        [JsonProperty("dice_value")]
        public int DiceValue { get; set; }
    }
    public class CreatingSpellSlot
    {
        [JsonProperty("spell_slot_level")]
        public int SpellSlotLevel { get; set; }

        [JsonProperty("sorcery_point_cost")]
        public int SorceryPointCost { get; set; }
    }
}

