using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using DungeonsAndDragonsInterface.DnDJsonFiles.SpellsFiles;
using DungeonsAndDragonsInterface.DnDJsonFiles.ClassesFiles;

namespace DungeonsAndDragonsInterface
{
    public static class Utility
    {
        const string Url = "https://www.dnd5eapi.co";
        private static readonly JsonSerializerSettings SerializerSettings = new() { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
        private static readonly HttpClient client = new();
        private static Dictionary<string, Spell> GeneratedSpells = new();
        private static Dictionary<string, Class> GeneratedClasses = new();
        private static Dictionary<string, List<LevelsForClass>> GeneratedLevels = new();

        public static async Task<string> GetRawJson(string item)
        {
            string uri = string.Concat(Url, item);
            string responseBody = await client.GetStringAsync(uri);

            return responseBody;
        }
        public static async Task<Spell> GetSpellAsync(string name)
        {
            string uri = string.Concat(Url, "/api/spells/", name.Replace(' ', '-').ToLower());
            if (GeneratedSpells.ContainsKey(uri))
            {
                return GeneratedSpells[uri];
            }
            else
            {
                try
                {
                    Spell spell = await Task.Run(async () => JsonConvert.DeserializeObject<Spell>(await client.GetStringAsync(uri), SerializerSettings));
                    if (spell != null)
                    {
                        GeneratedSpells.Add(uri, spell);
                        return spell;
                    }
                }
                catch
                {
                    return null;
                }
                return null;
            }
        }
        public static async Task<Class> GetClassAsync(string name)
        {
            string uri = string.Concat(Url, "/api/classes/", name.Replace(' ', '-').ToLower());
            if (GeneratedSpells.ContainsKey(uri))
            {
                return GeneratedClasses[uri];
            }
            else
            {
                try
                {
                    Class clas = await Task.Run(async () => JsonConvert.DeserializeObject<Class>(await client.GetStringAsync(uri), SerializerSettings));
                    if (clas != null)
                    {
                        GeneratedClasses.Add(uri, clas);
                        return clas;
                    }
                }
                catch
                {
                    return null;
                }
                return null;
            }
        }
        public static async Task<List<LevelsForClass>> GetLevelsForClassAsync(string path)
        {
            string uri = string.Concat(Url, path);
            if (GeneratedLevels.ContainsKey(uri))
            {
                return GeneratedLevels[path];
            }
            else
            {
                try
                {
                    List<LevelsForClass> levels = new();

                    for (int i = 1; i <= 20; i++)
                    {
                        levels.Add(await Task.Run(async () => JsonConvert.DeserializeObject<LevelsForClass>(await client.GetStringAsync(string.Concat(uri, $"/{1}")))));
                    }
                    if (levels.Count > 0)
                    {
                        return levels;
                    }
                }
                catch
                {
                    return null;
                }
                return null;
            }


        }
    }
}
