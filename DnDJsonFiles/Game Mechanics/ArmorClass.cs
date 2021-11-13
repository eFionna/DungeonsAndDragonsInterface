using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.Game_Mechanics
{
    public class ArmorClass
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("dex_bonus")]
        public bool DexBonus { get; set; }

        [JsonProperty("max_bonus")]
        public int MaxBonus { get; set; }
    }    
    
}
