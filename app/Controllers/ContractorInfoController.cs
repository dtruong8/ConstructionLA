using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SODA;
using Newtonsoft.Json;
using app.Models;
namespace app.Controllers
{
    public class ContractorInfoController
    {
        private IContractorRepository _contractor;
        public ContractorInfoController(IContractorRepository contractor){
            _contractor = contractor;
        }

        public string onGet(){
            string json = JsonConvert.SerializeObject(_contractor.getContractor());
            return json;

           
        }
    }
}		