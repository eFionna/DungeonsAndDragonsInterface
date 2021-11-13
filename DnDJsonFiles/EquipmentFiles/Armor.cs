using DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics;
using Newtonsoft.Json;


namespace DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles
{
   public class Armor : Equipment
    {

        [JsonProperty("armor_category")]
        public string ArmorCategory { get; set; }
        [JsonProperty("armor_class")]
        public ArmorClass ArmorClass { get; set; }
        [JsonProperty("str_minimum")]
        public int StrMinimum { get; set; }
        [JsonProperty("stealth_disadvantage")]
        public bool StealthDisadvantage { get; set; }

   }
}
