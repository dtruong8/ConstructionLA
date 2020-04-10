using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Newtonsoft.Json;

namespace app.Controllers
{
    [Route("[controller]")]
    public class ContractorInfoController: Controller
    {
        private IContractorInfoRepository _projectList;
        public ContractorInfoController (IContractorInfoRepository projectList)
        {
            _projectList = projectList;
        }

        [Route("[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        [Route("[action]")]
       public string GetAllProject()
        {
            return JsonConvert.SerializeObject(_projectList.getProjectList());
        }
    }
}