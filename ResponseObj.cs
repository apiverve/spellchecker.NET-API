using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class corrections
{
    [JsonProperty("word")]
    public string word { get; set; }

    [JsonProperty("suggestions")]
    public string[] suggestions { get; set; }

}

public class data
{
    [JsonProperty("spellPass")]
    public bool spellPass { get; set; }

    [JsonProperty("mispellingsFound")]
    public int mispellingsFound { get; set; }

    [JsonProperty("corrections")]
    public corrections[] corrections { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
