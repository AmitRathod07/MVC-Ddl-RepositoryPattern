using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MVC_Ddl_RepositoryPattern.Models;

namespace MVC_Ddl_RepositoryPattern.Repository
{
    internal interface ICountry
    {
        IEnumerable<Country> GetCountry();
    }
}
