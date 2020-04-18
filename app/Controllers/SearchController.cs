using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Nest;

namespace app.Controllers
{
    public class SearchController : Controller
    {
        private readonly IElasticClient _elasticClient;

    }
}