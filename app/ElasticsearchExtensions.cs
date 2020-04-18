using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;


namespace app
{
    public static class ElasticsearchExtensions
    {
        public static void AddElasticsearch(this IServiceCollection services, IConfiguration configuration)
        {
            var url = configuration["elasticsearch:url"];

            var settings = new ConnectionSettings(new Uri(url));

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);

        }
    }
}
