using bidtfal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bidtfal.Controllers
{
    public class HomeController : Controller
    {
        private ContributorRepository _contributorRepository = null;

        public HomeController()
        {
            _contributorRepository = new ContributorRepository();
        }
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
            var contibutors = _contributorRepository.GetContributors();

            return View(contibutors);
        }
    }
}