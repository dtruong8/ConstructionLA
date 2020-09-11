using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ViewModels
{
    public class TopRatedViewModel
    {
        public string contractor_business_name { get; set; }

        public decimal? rating { get; set; }
        public string business_category { get; set; }


    }
}
