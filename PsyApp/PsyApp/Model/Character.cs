using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PsyApp.Model
{
    public class Character
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("img")]
        public Uri Img { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("psiPowers")]
        public List<Power> Powers { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }
}
