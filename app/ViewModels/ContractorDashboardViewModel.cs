using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Nest;

namespace app.ViewModels
{
    public class ContractorDashboardViewModel
    {
        public string PageTitle { get; set; }
        public LicenseViewModel License { get; set; }
        public RankViewModel Rank { get; set; }
        public List<RecordsViewModel> Records { get; set; }

    }
    public class LicenseViewModel
    {
        public string address { get; set; }
        public string city {get;set;}
        public string state { get; set; }
        public int license_number { get; set; }
        public string license_type { get; set; }
        public string license_expire_date { get; set; }
      
    }

    public class RankViewModel
    {
        public string rating { get; set; }
        public string total_ratings { get; set; }
        public string website { get; set; }
    }

    public class RecordsViewModel 
    {
        public string permitnum { get; set; }
        public string permit_type { get; set; }
        public string permit_subtype { get; set; }
        public string category { get; set; }
        public string address_full { get; set; }
        public string issue_date { get; set; }
        public string status { get; set; }
        public string status_date { get; set; }
        public int valuation { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
    }
}
