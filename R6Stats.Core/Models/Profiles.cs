using System;
using System.Collections.Generic;
using System.Text;

namespace R6Stats.Core.Models
{
    public partial class Profiles
    {
        public long Totalresults { get; set; }
        public List<ProfilesDetails> Results { get; set; }

    }
    public partial class ProfilesDetails
    {
        public string P_id { get; set; }
        public string P_name { get; set; }
        public int P_level { get; set; }
        public double Kd { get; set; }
        public int P_currentmmr { get; set; }
        public string P_currentrank { get; set; }


    }
}
