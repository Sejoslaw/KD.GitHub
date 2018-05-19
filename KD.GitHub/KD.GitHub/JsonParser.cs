using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace KD.GitHub
{
    /// <summary>
    /// Used for parsing GitHub API response.
    /// </summary>
    internal static class JsonParser
    {
        public static void FillData(IDictionary<string, string> data, string jsonString)
        {
            JObject json = JObject.Parse(jsonString);
            json.Properties().ToList().ForEach(property =>
            {
                string key = property.Name;
                string value = property.Value.ToObject<string>();
                data.Add(key, value);
            });
        }
    }
}
