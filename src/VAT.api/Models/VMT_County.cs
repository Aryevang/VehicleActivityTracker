using System;
using System.ComponentModel.DataAnnotations;

namespace VAT.api.Models
{
    //VMT => Vehicle Miles Traveled
    public class VMT_County
    {
        [Key]
        public int ID { get; set; }
        public int county_fips { get; set; }
        public string county_name { get; set; }
        public string state_name { get; set; }
        public DateTime date { get; set; }
        public int county_vmt { get; set; }
        public int baseline_jan_vmt { get; set; }
        public float percent_change_from_jan { get; set; }
        public float mean7_county_vmt { get; set; }
        public float mean7_percent_change_from_jan { get; set; }
        public DateTime date_at_low { get; set; }
        public float mean7_county_vmt_at_low { get; set; }
        public float percent_change_from_low { get; set; }
    }
}