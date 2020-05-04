using System;
using Cassandra;
namespace app.Models
{
    public class Permit
    {
        public string permitnum { get; set; }
        public string status { get; set; }
        public string status_date { get; set; }
        public string permit_type { get; set; }
        public string permit_subtype { get; set; }
        public string category { get; set; }
        public string issue_date { get; set; }
        public string full_address { get; set; }
        public float valuation { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

}
 