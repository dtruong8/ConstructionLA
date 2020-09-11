using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using app.Models;
using app.ViewModels;

namespace app.Controllers
{
    [Route("[controller]")]
    public class TopRatedController : Controller
    {
        private IContractorRepository _contractor;
        public TopRatedController(IContractorRepository contractor)
        {
            _contractor = contractor;
        }
        [HttpGet]
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult TopRated()
        {
            List<TopRatedViewModel> topRatedViewModel = new List<TopRatedViewModel>();

            var result =
                (from doc in _contractor.getRanks().AsQueryable<Rank>()
                 orderby doc.rating descending
                 select doc);

            foreach (var doc in result)
            {
                if (doc.rating != null)
                {
                    topRatedViewModel.Add(new TopRatedViewModel()
                    {

                        contractor_business_name = doc.contractor_business_name,
                        rating = Convert.ToDecimal(doc.rating),
                        business_category = doc.business_category
                    });
                }
                else
                {
                    topRatedViewModel.Add(new TopRatedViewModel()
                    {

                        contractor_business_name = doc.contractor_business_name,
                        rating = null,
                        business_category = doc.business_category
                    });

                }
            }
            ViewData["Data"] = topRatedViewModel;
            ModelState.Clear();
            return View();
        }

    }
}
