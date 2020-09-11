using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nest;
using MongoDB.Driver;
using MongoDB.Bson;

namespace app.Models
{
    public class ContractorRepository : IContractorRepository
    {
        private List<Contractor> _contractorList = new List<Contractor>();
        private readonly IElasticClient _elasticClient;

        private readonly IMongoCollection<Rank> _collection_ratings;
        private readonly IMongoCollection<Contractor> _collection_license;
        private readonly IMongoClient _mongoClient;

        public ContractorRepository(IElasticClient elasticClient, IMongoClient mongoClient)
        {
            _elasticClient = elasticClient;
            _mongoClient = mongoClient;
            var database = _mongoClient.GetDatabase("constructionla_db");

            _collection_ratings = database.GetCollection<Rank>("business-ratings");
            _collection_license = database.GetCollection<Contractor>("business-info");
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

        public List<Rank> getRanks()
        {
            return _collection_ratings.Find(new BsonDocument()).ToList();
        }

        public List<Rank> getRankByName(string name)
        {
            return _collection_ratings.Find(x => x.contractor_business_name == name).ToList();
        }

        public List<Contractor> getLicenseByName(string name)
        {
            return _collection_license.Find(x => x.contractors_business_name == name).ToList();
        }

    }
}
