﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace R6Tab.NET.Models
{
    public class PlayerDataResults
    {
        public bool playerfound { get; set; }
        public Social social { get; set; }
        public List<Match> matches { get; set; }
        public string graph_NA_mmr_get { get; set; }
        public string graph_EU_mmr_get { get; set; }
        public string graph_AS_mmr_get { get; set; }
        public string graph_casualkds_get { get; set; }
        public string graph_rankedkds_get { get; set; }
        public string p_id { get; set; }
        public string p_name { get; set; }
        public string p_user { get; set; }
        public string p_level { get; set; }
        public string p_platform { get; set; }
        public string p_pvtrank { get; set; }
        public string utime { get; set; }
        public string kd { get; set; }
        public string p_data { get; set; }
        public string p_visitors { get; set; }
        public string p_currentrank { get; set; }
        public string p_currentmmr { get; set; }
        public string p_maxrank { get; set; }
        public string p_maxmmr { get; set; }
        public string p_skillrating { get; set; }
        public string thunt { get; set; }
        public string p_headshotacc { get; set; }
        public string p_NA_currentmmr { get; set; }
        public string p_NA_rank { get; set; }
        public string p_EU_currentmmr { get; set; }
        public string p_EU_rank { get; set; }
        public string p_AS_currentmmr { get; set; }
        public string p_AS_rank { get; set; }
        public string season6 { get; set; }
        public string season7 { get; set; }
        public string season8 { get; set; }
        public string season9 { get; set; }
        public string season10 { get; set; }
        public string season11 { get; set; }
        public string season12 { get; set; }
        public string faceit_id { get; set; }
        public string faceit_user { get; set; }
        public string faceit_elo { get; set; }
        public string faceit_level { get; set; }
        public string faceit_region { get; set; }
        public string faceit_country { get; set; }
        public string faceit_avatar { get; set; }
        public string esl_id { get; set; }
        public string social_twitter { get; set; }
        public string social_instagram { get; set; }
        public string social_twitch { get; set; }
        public string social_youtube { get; set; }
        public string operators { get; set; }
        public string weapons { get; set; }
        public string laststats { get; set; }
        public string allstats { get; set; }
        public string utime_stats { get; set; }
        public string season11rank { get; set; }
        public string season10rank { get; set; }
        public string season9rank { get; set; }
        public string season8rank { get; set; }
        public string season7rank { get; set; }
        public string season6rank { get; set; }
        public string season11mmr { get; set; }
        public string season10mmr { get; set; }
        public string season9mmr { get; set; }
        public string season8mmr { get; set; }
        public string season7mmr { get; set; }
        public string season6mmr { get; set; }
        public string updatedon { get; set; }
        public string btnav { get; set; }
        public string favattacker { get; set; }
        public string favdefender { get; set; }
        public string banreason { get; set; }
    }

    public class Social
    {
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string twitch { get; set; }
        public string youtube { get; set; }
        public string bio { get; set; }
        public string esl { get; set; }
        public string discord { get; set; }
        public string background { get; set; }
        public string aliases { get; set; }
        public string embed { get; set; }
    }

    public class Match
    {
        public string ranked_wlstatus { get; set; }
        public string ranked_winslost { get; set; }
        public string ranked_datatime { get; set; }
        public string next { get; set; }
        public int db_p_total_casualwins { get; set; }
        public int db_p_total_casuallosses { get; set; }
        public int db_p_total_casualkills { get; set; }
        public int db_p_total_casualdeaths { get; set; }
        public int db_p_total_rankedwins { get; set; }
        public int db_p_total_rankedlosses { get; set; }
        public int db_p_total_rankedkills { get; set; }
        public int db_p_total_rankeddeaths { get; set; }
        public int db_p_total_totalhs { get; set; }
        public string db_p_NA_currentmmr { get; set; }
        public string db_p_EU_currentmmr { get; set; }
        public object db_p_AS_currentmmr { get; set; }
        public int NA_mmrchange { get; set; }
        public int? EU_mmrchange { get; set; }
        public object AS_mmrchange { get; set; }
    }
}
