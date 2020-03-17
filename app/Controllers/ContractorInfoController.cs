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
        private ContractorRepository _contractor;
        public ContractorInfoController(ContractorRepository contractor){
            _contractor = contractor;
        }

        public IActionResult onGet(){
            return _contractor;
        }
    }
}