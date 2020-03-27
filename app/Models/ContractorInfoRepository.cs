using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SODA;

namespace app.Models
{
    public class ContractorInfoRepository : IContractorInfoRepository
    {
        private List<ContractorInfo> _projectList;
        
        public ContractorInfoRepository()
        {
            string name = "C M G - ELECTRIC";
            _projectList = new List<ContractorInfo>();
            var client = new SodaClient("https://data.lacity.org",
                "8YzE0NUTN2pl4gdOcY5fAquLi",
                "dtruong8@toromail.csudh.edu",
                "Helloworld123.");

            var soql = new SoqlQuery().Where("applicant_relationship = 'Contractor' and contractors_business_name = " + "'" + name + "'")
                                      .Order("issue_date");
            var dataset = client.GetResource<ContractorInfo>("yv23-pmwf");
            _projectList = dataset.Query<ContractorInfo>(soql).ToList();
        }

        public List<ContractorInfo> getProjectList()
        {
            return _projectList;
        }
    }
}