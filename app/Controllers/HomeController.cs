using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;
using SODA;
using Newtonsoft.Json;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult OpenDataLA()
        {
            return View();
        }

        public IActionResult SearchContractor()
        {
            return View();
        }
       // [HttpGet("[action]")]
        public string SodaResult(){
            var client = new SodaClient("data.lacity.org", "8YzE0NUTN2pl4gdOcY5fAquLi","dtruong8@toromail.csudh.edu","Helloworld123.");
            var soql = new SoqlQuery().Select("distinct contractors_business_name")
                                      .Where("applicant_relationship='Contractor'")
                                      .Order("contractors_business_name");
            var dataset = client.GetResource<ContractorModel>("yv23-pmwf");
            var results = dataset.Query<ContractorModel>(soql);
            string json = JsonConvert.SerializeObject(results);
            return json;
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
