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
        private static Dictionary<string, Spell> GeneratedSpells;
        private static Dictionary<string, Class> GeneratedClasses;
        private static Dictionary<string, List<LevelsForClass>> GeneratedLevels;

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
                return null;
            }
            else
            {
                try
                {
                    Spell spell = await Task.Run(async () => JsonConvert.DeserializeObject<Spell>(await client.GetStringAsync(uri), SerializerSettings));
                    if (spell != null)
                    {
                        if (saveResultInMemory)
                        {
                            GeneratedSpells.Add(uri, spell);
                        }
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
                return null;
            }
            else
            {
                try
                {
                    Class clas = await Task.Run(async () => JsonConvert.DeserializeObject<Class>(await client.GetStringAsync(uri), SerializerSettings));
                    if (clas != null)
                    {
                        if (saveResultInMemory)
                        {
                            GeneratedClasses.Add(uri, clas);
                        }
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
                return null;
            }
            else
            {
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
