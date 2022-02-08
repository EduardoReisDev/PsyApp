using System;
using Newtonsoft.Json;

namespace PsyApp.Model
{
    public class Power
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }
}
