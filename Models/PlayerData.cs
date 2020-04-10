using System;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class PlayerData
    {
        [JsonProperty("found")]
        public bool Found { get; set; }

        [JsonProperty("player")]
        public PlayerDetails Player { get; set; }

        [JsonProperty("ranked")]
        public RankedDetails Ranked { get; set; }

        [JsonProperty("refresh")]
        public RefreshDetails Refresh { get; set; }

        [JsonProperty("stats")]
        public StatDetails Stats { get; set; }
    }

    public class PlayerDetails
    {
        [JsonProperty("p_id")]
        public Guid Id { get; set; }

        [JsonProperty("p_user")]
        public Guid UserId { get; set; }

        [JsonProperty("p_name")]
        public string Name { get; set; }

        [JsonProperty("p_platform")]
        public string Platform { get; set; }
    }

    public class RankedDetails
    {
        [JsonProperty("AS_kills")]
        public int AsiaKills { get; set; }

        [JsonProperty("AS_deaths")]
        public int AsiaDeaths { get; set; }

        [JsonProperty("AS_wins")]
        public int AsiaWins { get; set; }

        [JsonProperty("AS_losses")]
        public int AsiaLosses { get; set; }

        [JsonProperty("AS_abandons")]
        public int AsiaAbandons { get; set; }

        [JsonProperty("AS_mmr")]
        public short AsiaMmr { get; set; }

        [JsonProperty("AS_maxmmr")]
        public short AsiaMaxMmr { get; set; }

        [JsonProperty("AS_champ")]
        public int AsiaChamp { get; set; }

        [JsonProperty("AS_mmrchange")]
        public int AsiaMmrChange { get; set; }

        [JsonProperty("AS_wl")]
        public string AsiaWinLossPercentage { get; set; }

        [JsonProperty("AS_kd")]
        public string AsiaKd { get; set; }

        [JsonProperty("AS_rank")]
        public byte AsiaRank { get; set; }

        [JsonProperty("AS_rankname")]
        public string AsiaRankName { get; set; }

        [JsonProperty("AS_maxrank")]
        public byte AsiaMaxRank { get; set; }

        [JsonProperty("AS_maxrankname")]
        public string AsiaMaxRankName { get; set; }

        [JsonProperty("AS_matches")]
        public int AsiaMatches { get; set; }

        [JsonProperty("AS_killpermatch")]
        public decimal AsiaKillsPerMatch { get; set; }

        [JsonProperty("AS_deathspermatch")]
        public decimal AsiaDeathsPerMatch { get; set; }
    }

    public class RefreshDetails
    {
        [JsonProperty("queued")]
        public bool Queued { get; set; }

        [JsonProperty("possible")]
        public bool Possible { get; set; }

        [JsonProperty("qtime")]
        public int QTime { get; set; }

        [JsonProperty("utime")]
        public int UTime { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class StatDetails
    {
        [JsonProperty("level")]
        public short Level { get; set; }
    }
}
