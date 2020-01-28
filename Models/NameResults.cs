using System;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class NameResults
    {
        [JsonProperty("results")]
        public PlayerResults[] PlayerResults { get; set; }

        [JsonProperty("totalresults")]
        public int TotalResults { get; set; }

    }

    public class PlayerResults
    {
        [JsonProperty("p_id")]
        public Guid PlayerId { get; set; }

        [JsonProperty("p_name")]
        public string PlayerName { get; set; }

        [JsonProperty("p_level")]
        public short PlayerLevel { get; set; }

        [JsonProperty("p_platform")]
        public string Platform { get; set; }

        [JsonProperty("p_user")]
        public Guid UserId { get; set; }

        [JsonProperty("p_currentmmr")]
        public short CurrentMmr { get; set; }

        [JsonProperty("p_currentrank")]
        public short CurrentRank { get; set; }

        [JsonProperty("p_kd")]
        public decimal Kd { get; set; }
    }
}
