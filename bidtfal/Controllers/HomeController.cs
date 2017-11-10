using bidtfal.Data;
using bidtfal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bidtfal.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ContactViewModel contacts = new ContactViewModel();
            contacts.Contributors = ContributorRepository.GetContributors();
            return View(contacts);
        }
    }
}