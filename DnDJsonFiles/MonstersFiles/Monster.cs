using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles
{
    public class Monster : APIReference
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }

        [JsonProperty("armor_class")]
        public int? ArmorClass { get; set; }

        [JsonProperty("hit_points")]
        public int? HitPoints { get; set; }

        [JsonProperty("hit_dice")]
        public string HitDice { get; set; }
        [JsonProperty("forms")]
        public APIReference Forms { get; set; }

        [JsonProperty("speed")]
        public Speed Speed { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("dexterity")]
        public int Dexterity { get; set; }

        [JsonProperty("constitution")]
        public int Constitution { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("wisdom")]
        public int Wisdom { get; set; }

        [JsonProperty("charisma")]
        public int Charisma { get; set; }

        [JsonProperty("proficiencies")]
        public List<Proficiency> Proficiencies = new();

        [JsonProperty("damage_vulnerabilities")]
        public List<string> DamageVulnerabilities = new();

        [JsonProperty("damage_resistances")]
        public List<string> DamageResistances = new();

        [JsonProperty("damage_immunities")]
        public List<string> DamageImmunities = new();

        [JsonProperty("condition_immunities")]
        public List<APIReference> ConditionImmunities = new();

        [JsonProperty("senses")]
        public Senses Senses { get; set; }

        [JsonProperty("languages")]
        public string Languages { get; set; }

        [JsonProperty("challenge_rating")]
        public float ChallengeRating { get; set; }

        [JsonProperty("xp")]
        public int? Xp { get; set; }

        [JsonProperty("special_abilities")]
        public List<SpecialAbility> SpecialAbilities = new();

        [JsonProperty("actions")]
        public List<Action> Actions = new();

        [JsonProperty("legendary_actions")]
        public List<LegendaryAction> LegendaryActions = new();
    }

}
