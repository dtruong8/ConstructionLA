using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace app.Models
{
    public interface IPermitRepository
    {
        List<Permit> Get();
        List<Permit> Get(string name);
         

    }
}
