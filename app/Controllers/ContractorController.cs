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
    public class ContractorController
    {
        private IContractorRepository _contractor;
        public ContractorController(IContractorRepository contractor)
        {
            _contractor = contractor;
        }
        [HttpGet]
        public string getFilteredContractors(string phrase)
        {
            string temp_name;
            List<Contractor> filteredresult = new List<Contractor>();
            List<Contractor> dataset = _contractor.getContractor();
            foreach(Contractor name in dataset)
            {
                if(name.contractors_business_name is null)
                {
                    break;
                }
                temp_name = name.contractors_business_name.ToString();

                if (temp_name.Contains(phrase))
                {
                    filteredresult.Add(name);
                }
            }
            return JsonConvert.SerializeObject(filteredresult);
        }
        [HttpGet]
        public string getAllContractors()
        {
            return JsonConvert.SerializeObject(_contractor.getContractor());
        }
    }
}