using DungeonsAndDragonsInterface.DnDJsonFiles.Common_Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class Class : APIReference
    {
        [JsonProperty("hit_die")]
        public int? HitDie { get; set; }

        [JsonProperty("proficiency_choices")]
        public List<ProficiencyChoice> ProficiencyChoices { get; set; }

        [JsonProperty("proficiencies")]
        public List<APIReference> Proficiencies { get; set; }

        [JsonProperty("saving_throws")]
        public List<APIReference> SavingThrows { get; set; }

        [JsonProperty("starting_equipment")]
        public List<StartingEquipment> StartingEquipment { get; set; }

        [JsonProperty("starting_equipment_options")]
        public List<StartingEquipmentOption> StartingEquipmentOptions { get; set; }

        [JsonProperty("class_levels")]
        public string ClassLevels { get; set; }

        [JsonProperty("subclasses")]
        public List<APIReference> Subclasses { get; set; }
    }
}
