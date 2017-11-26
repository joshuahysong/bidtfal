using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bidtfal.Areas.HexGame.Controllers
{
    public class HomeController : Controller
    {
        // GET: HexGame/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}