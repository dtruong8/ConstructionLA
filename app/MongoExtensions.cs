using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB;
using MongoDB.Driver;

namespace app
{
    public static class MongoExtensions
    {
        public static void AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionstring = configuration["mongodb:connnectionstring"];
            var client = new MongoClient("mongodb://admin:admin@localhost:27017");

            services.AddSingleton<IMongoClient>(client);
        }
    }
}
