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
    public class DashboardController: Controller
    {
        private IPermitRepository _projects;
        public DashboardController (IPermitRepository projects)
        {
            _projects = projects;
        }

        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Dashboard(string contractor_name)
        {
            IList<Permit> permitList = new List<Permit>();
            permitList = _projects.getProjectList(contractor_name);
            ViewData["permits"] = permitList;
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