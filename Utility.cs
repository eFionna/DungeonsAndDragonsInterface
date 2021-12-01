using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using DungeonsAndDragonsInterface.DnDJsonFiles.SpellsFiles;
using DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles;
using DungeonsAndDragonsInterface.DnDJsonFiles.MonstersFiles;
using DungeonsAndDragonsInterface.DnDJsonFiles.EquipmentFiles;
using Newtonsoft.Json.Linq;

namespace DungeonsAndDragonsInterface
{
    public static class Utility
    {
        const string Url = "https://www.dnd5eapi.co";
        private static readonly JsonSerializerSettings SerializerSettings = new() { NullValueHandling = NullValueHandling.Ignore };
        private static readonly HttpClient client = new();
        private static Dictionary<string, Spell> GeneratedSpells;
        private static Dictionary<string, Class> GeneratedClasses;
        private static Dictionary<string, List<LevelsForClass>> GeneratedLevels;
        private static Dictionary<string, Monster> GeneratedMonsters;
        private static Dictionary<string, Item> GeneratedEquipments;

        public static async Task<string> GetRawJson(string item)
        {
            string uri = string.Concat(Url, item);
            string responseBody = await client.GetStringAsync(uri);

            return responseBody;
        }
        public static async Task<Spell> GetSpellAsync(string name, bool saveResultInMemory = true)
        {
            if (saveResultInMemory && GeneratedSpells == null)
            {
                GeneratedSpells = new();
            }
            string uri = string.Concat(Url, "/api/spells/", name.Replace(' ', '-').ToLower());
            if (GeneratedSpells != null)
            {
                if (GeneratedSpells.ContainsKey(uri))
                {
                    return GeneratedSpells[uri];
                }
            }
            try
            {
                Spell spell = await Task.Run(async () => JsonConvert.DeserializeObject<Spell>(await client.GetStringAsync(uri), SerializerSettings));
                if (spell != null)
                {
                    if (saveResultInMemory)
                    {
                        GeneratedSpells.Add(uri, spell);
                    }
                }
                return spell;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<Class> GetClassAsync(string name, bool saveResultInMemory = true)
        {
            if (saveResultInMemory && GeneratedClasses == null)
            {
                GeneratedClasses = new();
            }
            string uri = string.Concat(Url, "/api/classes/", name.Replace(' ', '-').ToLower());
            if (GeneratedClasses != null)
            {
                if (GeneratedSpells.ContainsKey(uri))
                {
                    return GeneratedClasses[uri];
                }
            }
            try
            {
                Class clas = await Task.Run(async () => JsonConvert.DeserializeObject<Class>(await client.GetStringAsync(uri), SerializerSettings));
                if (clas != null)
                {
                    if (saveResultInMemory)
                    {
                        GeneratedClasses.Add(uri, clas);
                    }
                }
                return clas;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<List<LevelsForClass>> GetLevelsForClassAsync(string name, bool saveResultInMemory = true)
        {
            if (saveResultInMemory && GeneratedLevels == null)
            {
                GeneratedLevels = new();
            }
            string uri = string.Concat(Url, $"/api/classes/{name.Replace(' ', '-').ToLower()}/levels");
            if (GeneratedLevels != null)
            {
                if (GeneratedLevels.ContainsKey(uri))
                {
                    return GeneratedLevels[uri];
                }
            }
            try
            {
                List<LevelsForClass> levels = new();
                for (int i = 1; i <= 20; i++)
                {
                    levels.Add(await Task.Run(async () => JsonConvert.DeserializeObject<LevelsForClass>(await client.GetStringAsync(string.Concat(uri, $"/{i}")))));
                }
                if (levels.Count > 0)
                {
                    if (saveResultInMemory)
                    {
                        GeneratedLevels.Add(uri, levels);
                    }
                }
                return levels.Count > 0 ? levels : null;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<Monster> GetMonstersAsync(string name, bool saveResultInMemory = true)
        {
            if (saveResultInMemory && GeneratedMonsters == null)
            {
                GeneratedMonsters = new();
            }
            string uri = string.Concat(Url, "/api/monsters/", name.Replace(' ', '-').ToLower());
            if (GeneratedMonsters != null)
            {
                if (GeneratedMonsters.ContainsKey(uri))
                {
                    return GeneratedMonsters[uri];
                }
            }
            try
            {
                Monster monsters = await Task.Run(async () => JsonConvert.DeserializeObject<Monster>(await client.GetStringAsync(uri), SerializerSettings));
                if (monsters != null)
                {
                    if (saveResultInMemory)
                    {
                        GeneratedMonsters.Add(uri, monsters);
                    }
                }
                return monsters;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<Item> GetItemAsync(string name, bool saveResultInMemory = true)
        {
            if (saveResultInMemory && GeneratedEquipments == null)
            {
                GeneratedEquipments = new();
            }
            string uri = string.Concat(Url, "/api/equipment/", name.Replace(' ', '-').ToLower());
            if (GeneratedEquipments != null)
            {
                if (GeneratedEquipments.ContainsKey(uri))
                {
                    return GeneratedEquipments[uri];
                }
            }
            try
            {
                JObject json = JObject.Parse(await client.GetStringAsync(uri), new JsonLoadSettings()
                {
                    CommentHandling = CommentHandling.Load,
                });
                string category = json["equipment_category"].ToString();
                EquipmentCategory equipmentCategory = JsonConvert.DeserializeObject<EquipmentCategory>(category);
                Item item = null;
                switch (equipmentCategory.Name)
                {
                    case "Armor":
                    case "Heavy Armor":
                    case "Light Armor":
                    case "Medium Armor":
                    case "Shields":
                        item = JsonConvert.DeserializeObject<Armor>(json.ToString(), SerializerSettings);
                        break;
                    case "Adventuring Gear":
                    case "Ammunition":
                    case "Arcane Foci":
                    case "Druidic Foci":
                    case "Holy Symbols":
                    case "Kits":
                    case "Tack, Harness, and Drawn Vehicles":
                        item = JsonConvert.DeserializeObject<Gear>(json.ToString(), SerializerSettings);
                        break;
                    case "Tools":
                    case "Gaming Sets":
                    case "Musical Instruments":
                    case "Other Tools":
                        item = JsonConvert.DeserializeObject<Tool>(json.ToString(), SerializerSettings);
                        break;
                    case "Equipment Packs":
                        item = JsonConvert.DeserializeObject<EquipmentPack>(json.ToString(), SerializerSettings);
                        break;
                    case "Land Vehicle":
                    case "Mounts and Other Animals":
                    case "Mounts and Vehicles":
                    case "Waterborne Vehicles":
                        item = JsonConvert.DeserializeObject<Vehicle>(json.ToString(), SerializerSettings);
                        break ;
                    case "Martial Melee Weapons":
                    case "Martial Ranged Weapons":
                    case "Martial Weapons":
                    case "Melee Weapons":
                    case "Ranged Weapons":
                    case "Simple Melee Weapons":
                    case "Simple Ranged Weapons":
                    case "Simple Weapons":
                    case "Weapon":
                        item = JsonConvert.DeserializeObject<Weapon>(json.ToString(), SerializerSettings);
                        break;
                    case "Potion":
                    case "Ring":
                    case "Rod":
                    case "Scroll":
                    case "Staff":
                    case "Wand":
                    case "Wondrous Items":
                        item = JsonConvert.DeserializeObject<MagicItem>(json.ToString(), SerializerSettings);
                        break;
                    case "Standard Gear":
                        item = JsonConvert.DeserializeObject<Equipment>(json.ToString(), SerializerSettings);
                        break;
                }
                if (item != null)
                {
                    if (saveResultInMemory)
                    {
                        GeneratedEquipments.Add(uri, item);
                    }
                }
                return item;
            }
            catch
            {
                return null;
            }
        }
    }
}