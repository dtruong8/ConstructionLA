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
        public string getContractorInfo(string businessname){

            if (string.IsNullOrWhiteSpace(businessname)){
                return "Business Name required";
            }

            string attributes = "assessor_book, assessor_page, assessor_parcel, tract, block, lot, " +
                                "pcis_permit, latest_status, status_date, permit_type, "+
                                "permit_sub_type, permit_category, initiating_office, issue_date, address_start, "+
                                "address_end, street_direction, street_name, street_suffix,zip_code, work_description, "+
                                "valuation, contractors_business_name, contractor_address, contractor_city, contractor_state, "+
                                "license_type, license, principal_first_name, principal_last_name, license_expiration_date, "+
                                "applicant_first_name, applicant_last_name, zone, census_tract, council_district, location_1";

            string condition = "applicant_relationship = 'Contractor' AND contractors_business_name = '" + businessname + "'";

            var client = new SodaClient("https://data.lacity.org", 
                "8YzE0NUTN2pl4gdOcY5fAquLi",
                "dtruong8@toromail.csudh.edu",
                "Helloworld123."); 

            // SOQL string to get contractors business name
            var soql = new SoqlQuery().Select(attributes)
                                       .Where(condition);
            // Apply query to table Permit Information @ data.lacity.org
            var dataset = client.GetResource<ContractorInfoModel>("yv23-pmwf");
            // Return result to ContractorModel Object
            var results = dataset.Query<ContractorInfoModel>(soql);
            // Convert object into json string
            string json = JsonConvert.SerializeObject(results);
            return json;
        }
    }
}