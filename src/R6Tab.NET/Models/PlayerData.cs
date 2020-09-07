using System;
using System.Collections.Generic;
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

        [JsonProperty("seasons")]
        public Dictionary<string, SeasonDetails> Seasons { get; set; }

        [JsonProperty("history")]
        public Dictionary<string, Match> MatchHistory { get; set; }
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
        [JsonProperty("allkills")]
        public int Kills { get; set; }

        [JsonProperty("alldeaths")]
        public int Deaths { get; set; }

        [JsonProperty("allwins")]
        public int Wins { get; set; }

        [JsonProperty("alllosses")]
        public int Losses { get; set; }

        [JsonProperty("allabandons")]
        public int Abandons { get; set; }

        [JsonProperty("mmr")]
        public short Mmr { get; set; }

        [JsonProperty("allmaxmmr")]
        public short MaxMmr { get; set; }

        [JsonProperty("allchamp")]
        public int Champ { get; set; }

        [JsonProperty("best_mmrchange")]
        public int MmrChange { get; set; }

        [JsonProperty("allwl")]
        public string WinLossPercentage { get; set; }

        [JsonProperty("allkd")]
        public string Kd { get; set; }

        [JsonProperty("rank")]
        public byte Rank { get; set; }

        [JsonProperty("rankname")]
        public string RankName { get; set; }

        [JsonProperty("maxrank")]
        public byte MaxRank { get; set; }

        [JsonProperty("maxrankname")]
        public string MaxRankName { get; set; }

        [JsonProperty("allmatches")]
        public int Matches { get; set; }

        [JsonProperty("killpermatch")]
        public decimal KillsPerMatch { get; set; }

        [JsonProperty("deathspermatch")]
        public decimal DeathsPerMatch { get; set; }
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

    public class SeasonDetails
    {
        [JsonProperty("seasonname")]
        public string SeasonName { get; set; }

        [JsonProperty("maxrank")]
        public int? MaxRank { get; set; }

        [JsonProperty("maxrankname")]
        public string MaxRankName { get; set; }

        [JsonProperty("maxmmr")]
        public int? MaxMmr { get; set; }
    }

    public class Match
    {
        [JsonProperty("started")]
        public int Started { get; set; }

        [JsonProperty("ended")]
        public int Ended { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("ranked_wins")]
        public int RankedWins { get; set; }

        [JsonProperty("ranked_losses")]
        public int RankedLosses { get; set; }

        [JsonProperty("ranked_matches")]
        public int RankedMatches { get; set; }

        [JsonProperty("ranked_kills")]
        public int RankedKills { get; set; }

        [JsonProperty("ranked_deaths")]
        public int RankedDeaths { get; set; }

        [JsonProperty("ranked_kd")]
        public string RankedKd { get; set; }

        [JsonProperty("headshot_accuracy")]
        public string HeadshotAccuracy { get; set; }

        [JsonProperty("AS_mmrchange")]
        public string AsiaMmrChange { get; set; }
    }
}
