using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nest;

namespace app.Models
{
    public class ContractorRepository : IContractorRepository
    {
        private List<Contractor> _contractorList = new List<Contractor>();
        private readonly IElasticClient _elasticClient;

        public ContractorRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public List<Contractor> getContractor()
        {
            return _contractorList;
        }

        public List<Contractor> getSuggestions(string phrase)
        {
            List<Contractor> result = new List<Contractor>();
            var response = _elasticClient.Search<Contractor>(s => s
                                                             .Index("contractors")
                                                             .Query(q => q
                                                                .Prefix(p => p
                                                                    .Field(f => f.contractors_business_name)
                                                                    .Value(phrase)
                                                                    )
                                                              )
                                                             .Source(src => src
                                                                .Includes(i => i
                                                                    .Field(
                                                                        f => f.contractors_business_name)
                                                                    )
                                                                )
                                                             );
                                                             
                               
            if (!response.IsValid)
            {
                return result;
            }

            foreach(var doc in response.Documents)
            { 
                result.Add(new Contractor() 
                { 
                    contractors_business_name = doc.contractors_business_name
                });     
            }
            return result;
        }

    }
}
