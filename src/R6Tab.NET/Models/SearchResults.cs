using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class SearchResults
    {
        [JsonProperty("status")]
        public HttpStatusCode Status { get; set; }

        [JsonProperty("foundmatch")]
        public bool FoundMatch { get; set; }

        [JsonProperty("requested")]
        public string Requested { get; set; }

        [JsonProperty("players")]
        public Dictionary<string, Player> Players { get; set; }

    }

    public class Player
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("refresh")]
        public Refresh Refresh { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ranked")]
        public Ranked Ranked { get; set; }
    }

    public class Profile
    {
        [JsonProperty("p_id")]
        public Guid Id { get; set; }

        [JsonProperty("p_name")]
        public string Name { get; set; }

        [JsonProperty("p_user")]
        public Guid UserId { get; set; }

        [JsonProperty("p_platform")]
        public string Platform { get; set; }

        [JsonProperty("verified")]
        public bool IsVerified { get; set; }
    }

    public class Refresh
    {
        [JsonProperty("x")]
        public long LastTimeStatsUpdated { get; set; }

        [JsonProperty("s")]
        public long LastTimeProfileEdited { get; set; }
    }

    public class Stats
    {
        [JsonProperty("level")]
        public short Level { get; set; }
    }

    public class Ranked
    {
        [JsonProperty("kd")]
        public decimal Kd { get; set; }

        [JsonProperty("mmr")]
        public short Mmr { get; set; }

        [JsonProperty("rank")]
        public byte Rank { get; set; }

        [JsonProperty("champ")]
        public short Champ { get; set; }

        [JsonProperty("NA_mmr")]
        public short NaMmr { get; set; }

        [JsonProperty("NA_rank")]
        public byte NaRank { get; set; }

        [JsonProperty("NA_champ")]
        public short NaChamp { get; set; }

        [JsonProperty("EU_mmr")]
        public short EuMmr { get; set; }

        [JsonProperty("EU_rank")]
        public byte EuRank { get; set; }

        [JsonProperty("EU_champ")]
        public short EuChamp { get; set; }

        [JsonProperty("AS_mmr")]
        public short AsMmr { get; set; }

        [JsonProperty("AS_rank")]
        public byte AsRank { get; set; }

        [JsonProperty("AS_champ")]
        public short AsChamp { get; set; }
    }
}
