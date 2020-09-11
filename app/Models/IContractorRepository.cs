using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public interface IContractorRepository
    {
        // Provides autocomplete suggestions
        List<Contractor> getSuggestions(string phrase);
        List<Rank> getRanks();
        List<Rank> getRankByName(string name);

        List<Contractor> getLicenseByName(string name);
    }
}
