using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soda;

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
            var soql = new SoqlQuery().Where("applicant_relationship = 'Contractor'" );
            // Apply query to table Permit Information @ data.lacity.org
            var dataset = client.GetResource<_contractorList>("yv23-pmwf");
            // Return result to ContractorModel Object
            dataset.Query<_contractorList>(soql);
        }

        public string GetContractor()
        {
            return "GetContractor Method";
        }
    }
}
