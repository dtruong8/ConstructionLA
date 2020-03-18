using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SODA;
using Newtonsoft.Json;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class SearchContractorController
    {
        [HttpGet]
        public string getAllContractorNames(string phrase) {
            string condition1 = "applicant_relationship = 'Contractor' and contractors_business_name like %" + phrase + "%";
            string condition = "applicant_relationship = 'Contractor'";

            // Initialize connection to SodaClient
            var client = new SodaClient("https://data.lacity.org", 
                "8YzE0NUTN2pl4gdOcY5fAquLi",
                "dtruong8@toromail.csudh.edu",
                "Helloworld123."); 
            // SOQL string to get contractors business name
            var soql = new SoqlQuery().Select("distinct contractors_business_name")
                                       .Where(condition)
                                       .Order("contractors_business_name");
            // Apply query to table Permit Information @ data.lacity.org
            var dataset = client.GetResource<Contractor>("yv23-pmwf");
            // Return result to ContractorModel Object
            var results = dataset.Query<Contractor>(soql);
            // Convert object into json string
            string json = JsonConvert.SerializeObject(results);
            return json;
        }
    }
}
