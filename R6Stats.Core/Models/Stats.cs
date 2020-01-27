using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stats.Core.Models
{
    public partial class Stats
    {
        //public bool Playerfound { get; set; }
        //public List<Ranked> Ranked { get; set; }
        //public List<Social> Social { get; set; }
        public List<Seasonal> Seasonal { get; set; }
        //public List<Match> Match { get; set; }
        //public List<RootObject> RootObject { get; set; }

    }

    //public partial class Ranked
    //{
    //    public int mmr { get; set; }
    //    public int maxmmr { get; set; }
    //    public int rank { get; set; }
    //    public int maxrank { get; set; }
    //    public int NA_kills { get; set; }
    //    public int NA_deaths { get; set; }
    //    public int NA_wins { get; set; }
    //    public int NA_losses { get; set; }
    //    public int NA_abandons { get; set; }
    //    public int NA_mmr { get; set; }
    //    public int NA_maxmmr { get; set; }
    //    public int NA_rank { get; set; }
    //    public int NA_maxrank { get; set; }
    //    public int NA_champ { get; set; }
    //    public int NA_mmrchange { get; set; }
    //    public DateTime NA_updatedon { get; set; }
    //    public int EU_kills { get; set; }
    //    public int EU_deaths { get; set; }
    //    public int EU_wins { get; set; }
    //    public int EU_losses { get; set; }
    //    public int EU_abandons { get; set; }
    //    public int EU_mmr { get; set; }
    //    public int EU_maxmmr { get; set; }
    //    public int EU_rank { get; set; }
    //    public int EU_maxrank { get; set; }
    //    public int EU_champ { get; set; }
    //    public int EU_mmrchange { get; set; }
    //    public DateTime EU_updatedon { get; set; }
    //    public int AS_kills { get; set; }
    //    public int AS_deaths { get; set; }
    //    public int AS_wins { get; set; }
    //    public int AS_losses { get; set; }
    //    public int AS_abandons { get; set; }
    //    public int AS_mmr { get; set; }
    //    public int AS_maxmmr { get; set; }
    //    public int AS_rank { get; set; }
    //    public int AS_maxrank { get; set; }
    //    public int AS_champ { get; set; }
    //    public int AS_mmrchange { get; set; }
    //    public DateTime AS_updatedon { get; set; }
    //}

    //public partial class Social
    //{
    //    public string twitter { get; set; }
    //    public string instagram { get; set; }
    //    public string mixer { get; set; }
    //    public string twitch { get; set; }
    //    public string youtube { get; set; }
    //    public string bio { get; set; }
    //    public string esl { get; set; }
    //    public string discord { get; set; }
    //    public string background { get; set; }
    //    public string aliases { get; set; }
    //    public string embed { get; set; }
    //}

    public partial class Seasonal
    {
        public long Current_EU_mmr { get; set; }
        public long Last_EU_mmr { get; set; }
        public long Total_casualwins { get; set; }
        public long Total_casuallosses { get; set; }
        public long Total_casualtotal { get; set; }
        public long Total_casualkills { get; set; }
        public long Total_casualdeaths { get; set; }
        public long Total_rankedwins { get; set; }
        public long Total_rankedlosses { get; set; }
        public long Total_rankedtotal { get; set; }
        public long Total_rankedkills { get; set; }
        public long Total_rankeddeaths { get; set; }
        public long Total_generalwins { get; set; }
        public long Total_generallosses { get; set; }
        public long Total_generaltotal { get; set; }
        public long Total_generalkills { get; set; }
        public long Total_generaldeaths { get; set; }
    }
//    public partial class Match
//    {
//        public string casual_wlstatus { get; set; }
//        public string casual_winslost { get; set; }
//        public string casual_datatime { get; set; }
//        public string ranked_wlstatus { get; set; }
//        public string ranked_winslost { get; set; }
//        public string ranked_datatime { get; set; }
//        public string next { get; set; }
//        public int db_p_total_casualwins { get; set; }
//        public int db_p_total_casuallosses { get; set; }
//        public int db_p_total_casualkills { get; set; }
//        public int db_p_total_casualdeaths { get; set; }
//        public int db_p_total_rankedwins { get; set; }
//        public int db_p_total_rankedlosses { get; set; }
//        public int db_p_total_rankedkills { get; set; }
//        public int db_p_total_rankeddeaths { get; set; }
//        public int db_p_total_totalhs { get; set; }
//        public int db_p_NA_currentmmr { get; set; }
//        public int db_p_EU_currentmmr { get; set; }
//        public int db_p_AS_currentmmr { get; set; }
//        public int NA_mmrchange { get; set; }
//        public int EU_mmrchange { get; set; }
//        public int AS_mmrchange { get; set; }
//    }

//    public partial class Aliases
//    {
//        public string name { get; set; }
//}

//    public partial class RootObject
//    {
//        public bool playerfound { get; set; }
//        public Ranked ranked { get; set; }
//        public Social social { get; set; }
//        public Seasonal seasonal { get; set; }
//        public List<Match> matches { get; set; }
//        public string graph_NA_mmr_get { get; set; }
//        public string graph_EU_mmr_get { get; set; }
//        public string graph_AS_mmr_get { get; set; }
//        public string graph_casualkds_get { get; set; }
//        public string graph_rankedkds_get { get; set; }
//        public Aliases aliases { get; set; }
//        public int season6mmr { get; set; }
//        public int season6rank { get; set; }
//        public int season7mmr { get; set; }
//        public int season7rank { get; set; }
//        public int season8mmr { get; set; }
//        public int season8rank { get; set; }
//        public int season9mmr { get; set; }
//        public int season9rank { get; set; }
//        public int season10mmr { get; set; }
//        public int season10rank { get; set; }
//        public int season11mmr { get; set; }
//        public int season11rank { get; set; }
//        public int season12mmr { get; set; }
//        public int season12rank { get; set; }
//        public int season13mmr { get; set; }
//        public int season13rank { get; set; }
//        public int season14mmr { get; set; }
//        public int season14rank { get; set; }
//        public int season15mmr { get; set; }
//        public int season15rank { get; set; }
//        public string updatedon { get; set; }
//        public string btnav { get; set; }
//        public string favattacker { get; set; }
//        public string favdefender { get; set; }
//        public string banreason { get; set; }
//        public string bansource { get; set; }
//        public string p_id { get; set; }
//        public string p_name { get; set; }
//        public string p_user { get; set; }
//        public string p_customurl { get; set; }
//        public int p_level { get; set; }
//        public string p_platform { get; set; }
//        public int p_pvtrank { get; set; }
//        public int verified { get; set; }
//        public int utime { get; set; }
//        public int kd { get; set; }
//        public string p_data { get; set; }
//        public int p_visitors { get; set; }
//        public int p_currentrank { get; set; }
//        public int p_currentmmr { get; set; }
//        public int p_maxrank { get; set; }
//        public int p_maxmmr { get; set; }
//        public int p_skillrating { get; set; }
//        public string thunt { get; set; }
//        public int p_headshotacc { get; set; }
//        public int p_NA_currentmmr { get; set; }
//        public int p_NA_rank { get; set; }
//        public int p_EU_currentmmr { get; set; }
//        public int p_EU_rank { get; set; }
//        public int p_AS_currentmmr { get; set; }
//        public int p_AS_rank { get; set; }
//        public int season6 { get; set; }
//        public int season7 { get; set; }
//        public int season8 { get; set; }
//        public int season9 { get; set; }
//        public int season10 { get; set; }
//        public int season11 { get; set; }
//        public int season12 { get; set; }
//        public int season13 { get; set; }
//        public int season14 { get; set; }
//        public string season6data { get; set; }
//        public string season7data { get; set; }
//        public string season8data { get; set; }
//        public string season9data { get; set; }
//        public string season10data { get; set; }
//        public string season11data { get; set; }
//        public string season12data { get; set; }
//        public string season13data { get; set; }
//        public string season14data { get; set; }
//        public object faceit_id { get; set; }
//        public object faceit_user { get; set; }
//        public object faceit_elo { get; set; }
//        public object faceit_level { get; set; }
//        public object faceit_region { get; set; }
//        public object faceit_country { get; set; }
//        public object faceit_avatar { get; set; }
//        public string operators { get; set; }
//        public string operators_season { get; set; }
//        public List<int> data { get; set; }
//    }
}
