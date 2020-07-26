using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;


namespace app.Models
{
    public class PermitRepository : IPermitRepository
    {
        private readonly IMongoCollection<Permit> _permits;
        private readonly IMongoClient _mongoClient;

        
        public PermitRepository(IMongoClient _mongoDBClient)
        {
            _mongoClient = _mongoDBClient;
            var database = _mongoClient.GetDatabase("construction_db");
            _permits = database.GetCollection<Permit>("permits");
        }

        public List<Permit> getAllProjectList()
        {
            return _permits.Find(new BsonDocument()).ToList();
        }

        public List<Permit> getProjectList(string name)
        {
            return _permits.Find(x => x.contractor_business_name == name).ToList();
        }
    }
}