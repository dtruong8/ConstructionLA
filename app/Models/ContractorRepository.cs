using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SODA;
using Newtonsoft.Json;

namespace app.Models
{
    public class ContractorRepository : IContractorRepository
    {
        private List<Contractor> _contractorList;

        public ContractorRepository()
        {
            _contractorList = new List<Contractor>();
            var client = new SodaClient("https://data.lacity.org", 
                "8YzE0NUTN2pl4gdOcY5fAquLi",
                "dtruong8@toromail.csudh.edu",
                "Helloworld123."); 

            // SOQL string to get contractors business name
            var soql = new SoqlQuery().Select("distinct contractors_business_name")
                                      .Where("applicant_relationship = 'Contractor'" );
            // Apply query to table Permit Information @ data.lacity.org
            var dataset = client.GetResource<Contractor>("yv23-pmwf");
            // Return json Object
            _contractorList = dataset.Query<Contractor>(soql).ToList();
            // Convert object into json string
            string json = JsonConvert.SerializeObject(_contractorList);
        }

        public List<Contractor> getContractor()
        {
            return _contractorList;
        }
    }
}
