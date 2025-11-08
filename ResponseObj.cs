using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Corrections data
    /// </summary>
    public class Corrections
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("suggestions")]
        public string[] Suggestions { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("spellPass")]
        public bool SpellPass { get; set; }

        [JsonProperty("mispellingsFound")]
        public int MispellingsFound { get; set; }

        [JsonProperty("corrections")]
        public Corrections[] Corrections { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
