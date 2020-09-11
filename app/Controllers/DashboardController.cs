using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using app.Models;
using Newtonsoft.Json;
using app.ViewModels;
using Nest;
using Microsoft.CodeAnalysis;

namespace app.Controllers
{
    [Route("[controller]")]
    public class DashboardController: Controller
    {
        private IPermitRepository _projects;
        private IContractorRepository _contractor;
        public DashboardController (IPermitRepository projects, IContractorRepository contractor)
        {
            _projects = projects;
            _contractor = contractor;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[action]")]
        public IActionResult Dashboard(Contractor contractor)
        {
            LicenseViewModel licenseViewModel = new LicenseViewModel();
            RankViewModel rankViewModel = new RankViewModel();
            List<RecordsViewModel> records = new List<RecordsViewModel>();
            string contractor_name = contractor.contractors_business_name.ToString();

           foreach(var doc in _contractor.getLicenseByName(contractor_name))
            {
                licenseViewModel.address = doc.address;
                licenseViewModel.city = doc.city;
                licenseViewModel.state = doc.state;
                licenseViewModel.license_number = doc.license_number;
                licenseViewModel.license_type = doc.license_type;
                licenseViewModel.license_expire_date = doc.license_expire_date;
            }

            foreach(var doc in _contractor.getRankByName(contractor_name))
            {
                rankViewModel.rating = doc.rating.ToString();
                rankViewModel.total_ratings = doc.total_ratings;
                rankViewModel.website = doc.website;
            }

            foreach(var doc in _projects.Get(contractor_name))
            {
                records.Add(new RecordsViewModel()
                {
                    permitnum = doc.permitnum,
                    permit_type = doc.permit_type,
                    permit_subtype = doc.permit_subtype,
                    category = doc.category,
                    address_full = doc.address_full,
                    issue_date = doc.issue_date,
                    status = doc.status,
                    status_date = doc.status_date,
                    valuation = doc.valuation,
                    longitude = doc.longitude,
                    latitude = doc.latitude
                }) ;
            }

            ContractorDashboardViewModel contractorDashboardViewModel = new ContractorDashboardViewModel()
            {
                PageTitle = contractor_name,
                License = licenseViewModel,
                Rank = rankViewModel,
                Records = records
            };
            ViewData["Data"] = contractorDashboardViewModel;
            ViewData["Contractor Name"] = contractorDashboardViewModel.PageTitle.ToString();
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        [Route("[action]")]
        public string GetAllProject(string contractor_name)
        {
            return JsonConvert.SerializeObject(_projects.Get(contractor_name));

        }
    }
}