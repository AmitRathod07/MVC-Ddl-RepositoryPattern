using MVC_Ddl_RepositoryPattern.Models;
using MVC_Ddl_RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ddl_RepositoryPattern.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country

        private ICountry icou;

        public CountryController()
        {
            this.icou = new RepositoryCountry(new OrganizationEntities()); ;
        }

        public ActionResult Index()
        {
            var countrylist = icou.GetCountry().ToList();
            ViewBag.Countrynames = new SelectList(countrylist, "Cid", "Cname"); 
            return View(countrylist);
        }
    }
}