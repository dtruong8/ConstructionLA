using System;

namespace app.Models
{
    public class ContractorInfoModel
    {
        public string assessor_book { get; set; }
        public string assessor_page{get;set;}
        public string assessor_parcel{get;set;}
        public string tract{get;set;}
        public string block{get;set;}
        public string lot{get;set;}
        public string pcis_permit{get;set;}
        public string latest_status{get;set;}
        public string status_date{get;set;}
        public string permit_type {get;set;}
        public string permit_sub_type{get;set;}
        public string permit_category{get;set;}
        public int project_number{get;set;}
        public string event_code{get;set;}
        public string initiating_office{get;set;}
        public string issue_date{get;set;}
        public int address_start{get;set;}
        public string address_fraction_start{get;set;}
        public int address_end{get;set;}
        public string address_fraction_end{get;set;}
        public string street_direction{get;set;}
        public string street_name{get;set;}
        public string street_suffix{get;set;}
        public string suffix_direction{get;set;}
        public string unit_range_start{get;set;}
        public string unit_range_end{get;set;}
        public int zip_code{get;set;}
        public string work_description{get;set;}
        public int valuation{get;set;}
        public int floor_area_l_a_zoning_code_definition {get;set;}
        public int  of_residential_dwelling_units {get;set;}
        public int _of_accessory_dwelling_un {get;set;}
        public string contractors_business_name {get;set;}
        public string contractor_address {get;set;}
        public string contractor_city {get;set;}
        public string contractor_state{get;set;}
        public string license_type{get;set;}
        public int license{get;set;}
        public string principal_first_name{get;set;}
        public string principal_middle_name{get;set;}
        public string principal_last_name{get;set;}
        public string license_expiration_date{get;set;}
        public string applicant_first_name{get;set;}
        public string applicant_last_name{get;set;}
        public string zone{get;set;}
        public string floor_area_l_a_building_code_definition{get;set;}
        public string census_tract{get;set;}
        public string council_district{get;set;}
        public geocode location_1 {get;set;}
        public string applicant_relationship{get;set;}
    }
    public class geocode{
        public string longitude{get;set;}
        public string latitude{get;set;}
    }

}
 