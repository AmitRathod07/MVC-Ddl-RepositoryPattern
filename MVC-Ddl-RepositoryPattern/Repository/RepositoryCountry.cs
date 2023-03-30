using MVC_Ddl_RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Ddl_RepositoryPattern.Repository
{
    public class RepositoryCountry : ICountry
    {

        private OrganizationEntities organizationEntities;

        public RepositoryCountry(OrganizationEntities organizationEntities) 
        {
            this.organizationEntities = organizationEntities; ;   
        }
        public IEnumerable<Country> GetCountry()
        {
            return organizationEntities.Countries.ToList();
        }
    }
}