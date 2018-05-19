using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KD.GitHub
{
    /// <summary>
    /// Used for parsing GitHub API response.
    /// </summary>
    internal static class JsonParser
    {
        public static void FillData(IDictionary<string, object> data, string jsonString)
        {
            JObject json = JObject.Parse(jsonString);
            json.Properties().ToList().ForEach(property =>
            {
                string key = property.Name;
                object value = "";

                try
                {
                    value = property.Value.ToObject<string>();
                }
                catch (Exception)
                {
                    value = property.Value.ToObject<object>();
                }

                data.Add(key, value);
            });
        }

        public static void ParseCollection(string url, Action<JToken> HandleElement)
        {
            string httpResponse = RequestSender.Get(url);

            JArray array = JArray.Parse(httpResponse);
            array.ToList().ForEach(token =>
            {
                HandleElement?.Invoke(token);
            });
        }
    }
}
