using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public string autocomplete(string phrase)
        {
            return JsonConvert.SerializeObject(_contractor.getSuggestions(phrase));
        }

    }
}