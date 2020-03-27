using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Newtonsoft.Json;

namespace app.Controllers
{
    public class ContractorInfoController
    {
        private IContractorInfoRepository _projectList;
        public ContractorInfoController (IContractorInfoRepository projectList)
        {
            _projectList = projectList;
        }

       [HttpGet]
       public string getAllProject()
        {
            return JsonConvert.SerializeObject(_projectList.getProjectList());
        }
    }
}