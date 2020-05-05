using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using app.Models;
using Newtonsoft.Json;

namespace app.Controllers
{
    [Route("[controller]")]
    public class DashboardController: Controller
    {
        private IPermitRepository _projects;
        public DashboardController (IPermitRepository projects)
        {
            _projects = projects;
        }

        [HttpGet]
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Dashboard(Contractor contractor)
        {
            string contractor_name = contractor.contractors_business_name.ToString();
            IList<Permit> permitList = new List<Permit>();
            ViewData["Contractor Name"] = contractor_name;
            permitList = _projects.getProjectList(contractor_name);
            ViewData["Permits"] = permitList;
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        [Route("[action]")]
       public string GetAllProject(string contractor_name)
        {
            return JsonConvert.SerializeObject(_projects.getProjectList(contractor_name));
        }
    }
}