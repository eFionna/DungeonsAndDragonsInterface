using Newtonsoft.Json;

namespace DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles
{
    public class SubclassSpecific
    {
        [JsonProperty("additional_magical_secrets_max_lvl")]
        public int AdditionalMagicalSecretsMaxLvl { get; set; }

        [JsonProperty("aura_range")]
        public int AuraRange { get; set; }
    }
}
