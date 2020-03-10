using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class MockContractorRepository : IContractorRepository
    {
        private List<Contractor> _contractorList;

        public MockContractorRepository()
        {
            _contractorList = new List<Contractor>()
            {
                new Contractor(){contractor_business_name = "Dean INC"},
                new Contractor(){contractor_business_name = "Gaby INC" },
                new Contractor(){ contractor_business_name = "Nicholas INC"},
            };
        }

        public Contractor GetContractor()
        {
            return _contractorList.FirstOrDefault<>
        }
    }
}
