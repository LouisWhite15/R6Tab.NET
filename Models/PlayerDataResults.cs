using System;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class PlayerDataResults
    {
        [JsonProperty("playerfound")]
        public bool PlayerFound { get; set; }

        [JsonProperty("social")]
        public Social Social { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("graph_NA_mmr_get")]
        public string GraphNaMmr { get; set; }

        [JsonProperty("graph_EU_mmr_get")]
        public string GraphEuMmr { get; set; }

        [JsonProperty("graph_AS_mmr_get")]
        public string GraphAsMmr { get; set; }

        [JsonProperty("graph_casualkds_get")]
        public string GraphCasualkds { get; set; }

        [JsonProperty("graph_rankedkds_get")]
        public string GraphRankedkds { get; set; }

        [JsonProperty("p_id")]
        public Guid PlayerId { get; set; }

        [JsonProperty("p_name")]
        public string PlayerName { get; set; }

        [JsonProperty("p_user")]
        public Guid UserId { get; set; }

        [JsonProperty("p_level")]
        public long PlayerLevel { get; set; }

        [JsonProperty("p_platform")]
        public string PlayerPlatform { get; set; }

        [JsonProperty("p_pvtrank")]
        public long PlayerPvtrank { get; set; }

        [JsonProperty("utime")]
        public long Utime { get; set; }

        [JsonProperty("kd")]
        public long Kd { get; set; }

        [JsonProperty("p_data")]
        public string PlayerData { get; set; }

        [JsonProperty("p_visitors")]
        public long PlayerVisitors { get; set; }

        [JsonProperty("p_currentrank")]
        public long PlayerCurrentRank { get; set; }

        [JsonProperty("p_currentmmr")]
        public long PlayerCurrentMmr { get; set; }

        [JsonProperty("p_maxrank")]
        public long PlayerMaxRank { get; set; }

        [JsonProperty("p_maxmmr")]
        public long PlayerMaxMmr { get; set; }

        [JsonProperty("p_skillrating")]
        public long PlayerSkillRating { get; set; }

        [JsonProperty("thunt")]
        public string Thunt { get; set; }

        [JsonProperty("p_headshotacc")]
        public long PlayerHeadshotAccuracy { get; set; }

        [JsonProperty("p_NA_currentmmr")]
        public long PlayerNaCurrentMmr { get; set; }

        [JsonProperty("p_NA_rank")]
        public long PlayerNaRank { get; set; }

        [JsonProperty("p_EU_currentmmr")]
        public long PlayerEuCurrentMmr { get; set; }

        [JsonProperty("p_EU_rank")]
        public long PlayerEuRank { get; set; }

        [JsonProperty("p_AS_currentmmr")]
        public long PlayerAsCurrentMmr { get; set; }

        [JsonProperty("p_AS_rank")]
        public long PlayerAsRank { get; set; }

        [JsonProperty("season6")]
        public string Season6 { get; set; }

        [JsonProperty("season7")]
        public string Season7 { get; set; }

        [JsonProperty("season8")]
        public string Season8 { get; set; }

        [JsonProperty("season9")]
        public string Season9 { get; set; }

        [JsonProperty("season10")]
        public string Season10 { get; set; }

        [JsonProperty("season11")]
        public string Season11 { get; set; }

        [JsonProperty("season12")]
        public string Season12 { get; set; }

        [JsonProperty("faceit_id")]
        public string FaceitId { get; set; }

        [JsonProperty("faceit_user")]
        public string FaceitUser { get; set; }

        [JsonProperty("faceit_elo")]
        public long FaceitElo { get; set; }

        [JsonProperty("faceit_level")]
        public long FaceitLevel { get; set; }

        [JsonProperty("faceit_region")]
        public string FaceitRegion { get; set; }

        [JsonProperty("faceit_country")]
        public string FaceitCountry { get; set; }

        [JsonProperty("faceit_avatar")]
        public string FaceitAvatar { get; set; }

        [JsonProperty("esl_id")]
        public string EslId { get; set; }

        [JsonProperty("social_twitter")]
        public string SocialTwitter { get; set; }

        [JsonProperty("social_instagram")]
        public string SocialInstagram { get; set; }

        [JsonProperty("social_twitch")]
        public string SocialTwitch { get; set; }

        [JsonProperty("social_youtube")]
        public Uri SocialYoutube { get; set; }

        [JsonProperty("operators")]
        public string Operators { get; set; }

        [JsonProperty("weapons")]
        public string Weapons { get; set; }

        [JsonProperty("laststats")]
        public string LastStats { get; set; }

        [JsonProperty("allstats")]
        public string AllStats { get; set; }

        [JsonProperty("utime_stats")]
        public long UtimeStats { get; set; }

        [JsonProperty("season11rank")]
        public long Season11Rank { get; set; }

        [JsonProperty("season10rank")]
        public long Season10Rank { get; set; }

        [JsonProperty("season9rank")]
        public long Season9Rank { get; set; }

        [JsonProperty("season8rank")]
        public long Season8Rank { get; set; }

        [JsonProperty("season7rank")]
        public long Season7Rank { get; set; }

        [JsonProperty("season6rank")]
        public long Season6Rank { get; set; }

        [JsonProperty("season11mmr")]
        public long Season11Mmr { get; set; }

        [JsonProperty("season10mmr")]
        public long Season10Mmr { get; set; }

        [JsonProperty("season9mmr")]
        public long Season9Mmr { get; set; }

        [JsonProperty("season8mmr")]
        public long Season8Mmr { get; set; }

        [JsonProperty("season7mmr")]
        public long Season7Mmr { get; set; }

        [JsonProperty("season6mmr")]
        public long Season6Mmr { get; set; }

        [JsonProperty("updatedon")]
        public string UpdatedOn { get; set; }

        [JsonProperty("btnav")]
        public bool BtNav { get; set; }

        [JsonProperty("favattacker")]
        public string FavAttacker { get; set; }

        [JsonProperty("favdefender")]
        public string FavDefender { get; set; }

        [JsonProperty("banreason")]
        public string BanReason { get; set; }
    }

    public partial class Match
    {
        [JsonProperty("ranked_wlstatus")]
        public string RankedWlStatus { get; set; }

        [JsonProperty("ranked_winslost")]
        public string RankedWinsLost { get; set; }

        [JsonProperty("ranked_datatime")]
        public string RankedDataTime { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("db_p_total_casualwins")]
        public long DbPTotalCasualWins { get; set; }

        [JsonProperty("db_p_total_casuallosses")]
        public long DbPTotalCasualLosses { get; set; }

        [JsonProperty("db_p_total_casualkills")]
        public long DbPTotalCasualKills { get; set; }

        [JsonProperty("db_p_total_casualdeaths")]
        public long DbPTotalCasualDeaths { get; set; }

        [JsonProperty("db_p_total_rankedwins")]
        public long DbPTotalRankedWins { get; set; }

        [JsonProperty("db_p_total_rankedlosses")]
        public long DbPTotalRankedLosses { get; set; }

        [JsonProperty("db_p_total_rankedkills")]
        public long DbPTotalRankedKills { get; set; }

        [JsonProperty("db_p_total_rankeddeaths")]
        public long DbPTotalRankedDeaths { get; set; }

        [JsonProperty("db_p_total_totalhs")]
        public long DbPTotalTotalHs { get; set; }

        [JsonProperty("db_p_NA_currentmmr")]
        public long DbPNaCurrentMmr { get; set; }

        [JsonProperty("db_p_EU_currentmmr")]
        public long DbPEuCurrentMmr { get; set; }

        [JsonProperty("db_p_AS_currentmmr")]
        public object DbPAsCurrentMmr { get; set; }

        [JsonProperty("NA_mmrchange")]
        public long NaMmrChange { get; set; }

        [JsonProperty("EU_mmrchange")]
        public long EuMmrChange { get; set; }

        [JsonProperty("AS_mmrchange")]
        public object AsMmrChange { get; set; }
    }

    public partial class Social
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("twitch")]
        public string Twitch { get; set; }

        [JsonProperty("youtube")]
        public Uri Youtube { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("esl")]
        public Uri Esl { get; set; }

        [JsonProperty("discord")]
        public Uri Discord { get; set; }

        [JsonProperty("background")]
        public Uri Background { get; set; }

        [JsonProperty("aliases")]
        public long Aliases { get; set; }

        [JsonProperty("embed")]
        public string Embed { get; set; }
    }
}
