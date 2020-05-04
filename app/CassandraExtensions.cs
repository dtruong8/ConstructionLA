using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cassandra;

namespace app
{
    public static class CassandraExtensions
    {
        public static void AddCassandra(this IServiceCollection services, IConfiguration configuration)
        {
            var ip = configuration["cassandra:host"];

            // connection to Cassanda
            var cluster = Cluster.Builder().AddContactPoint(ip).Build();

            // connect to matrix keyspace
            var session = cluster.Connect("matrix");

            services.AddSingleton<ISession>(session);
        }
    }
}
