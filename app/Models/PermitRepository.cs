using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cassandra;


namespace app.Models
{
    public class PermitRepository : IPermitRepository
    {
        private List<Permit> _projectList;
        private readonly ISession _cassandraClient;

        
        public PermitRepository(ISession cassandraClient)
        {
            _cassandraClient = cassandraClient;
        }

        public List<Permit> getAllProjectList()
        {
            List<Permit> result = new List<Permit>();
            var response = _cassandraClient.Execute("SELECT permitnum, status, status_date, " +
                                                            "permit_type, permit_subtype, category, " +
                                                            "issue_date, full_address, valuation, latitude, longitude " +
                                                    "FROM ladbs");
            foreach (var row in response)
            {
                result.Add(new Permit()
                {
                    permitnum = row.GetValue<string>("permitnum"),
                    status = row.GetValue<string>("status"),
                    status_date = row.GetValue<string>("status_date"),
                    permit_type = row.GetValue<string>("permit_type"),
                    permit_subtype = row.GetValue<string>("permit_subtype"),
                    category = row.GetValue<string>("category"),
                    issue_date = row.GetValue<string>("issue_date"),
                    full_address = row.GetValue<string>("full_address"),
                    valuation = row.GetValue<float>("valuation"),
                    latitude = row.GetValue<float>("latitude"),
                    longitude = row.GetValue<float>("longitude")
                });
            }

            return result;
        }

        public List<Permit> getProjectList(string name)
        {
            List<Permit> result = new List<Permit>();
            var response = _cassandraClient.Execute("SELECT permitnum, status, CAST(status_date AS TEXT), " +
                                                            "permit_type, permit_subtype, category, " +
                                                            "issue_date, full_address, valuation, latitude, longitude  " +
                                                    "FROM ladbs " +
                                                    "WHERE contractors_business_name = " + "'" + name + "' ALLOW FILTERING");

            foreach(var row in response)
            {
                result.Add(new Permit()
                {
                    permitnum = row.GetValue<string>("permitnum"),
                    status = row.GetValue<string>("status"),
                    status_date = row.GetValue<string>("status_date"),
                    permit_type = row.GetValue<string>("permit_type"),
                    permit_subtype = row.GetValue<string>("permit_subtype"),
                    category = row.GetValue<string>("category"),
                    issue_date = row.GetValue<string>("issue_date"),
                    full_address = row.GetValue<string>("full_address"),
                    valuation = row.GetValue<float>("valuation"),
                    latitude = row.GetValue<float>("latitude"),
                    longitude = row.GetValue<float>("longitude")
                }) ;
            }

            return result;
        }
    }
}