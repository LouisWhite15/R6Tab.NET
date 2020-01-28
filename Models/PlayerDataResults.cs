using System;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class PlayerDataResults
    {
        [JsonProperty("playerfound")]
        public bool PlayerFound { get; set; }

        [JsonProperty("p_id")]
        public Guid PlayerId { get; set; }

        [JsonProperty("p_name")]
        public string PlayerName { get; set; }
    }
}
