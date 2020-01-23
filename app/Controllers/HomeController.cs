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
        /*
        public IActionResult SodaResult(){
            var client = new SodaClient("data.smgov.net", "8YzE0NUTN2pl4gdOcY5fAquLi");
            var soql = new SoqlQuery().Select("column1", "column2")
                          .Where("something > nothing")
                          .Group("column3");
            return View();
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
