using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.AspNetCore.Routing;
using System.Net;

namespace app.Models
{
    public class PermitRepository : IPermitRepository
    {
        private readonly IMongoCollection<Permit> _collection;
        private readonly IMongoClient _mongoClient;

        
        public PermitRepository(IMongoClient _mongoDBClient)
        {
            _mongoClient = _mongoDBClient;
            var database = _mongoClient.GetDatabase("constructionla_db");
            _collection = database.GetCollection<Permit>("permits");
        }

        public List<Permit> Get()
        {
            return _collection.Find(new BsonDocument()).ToList();
        }

        public List<Permit> Get(string name)
        {
            return _collection.Find(x => x.contractor_business_name == name).ToList();
        }

    }
}