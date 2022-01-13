using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net6_sharp10_lib;

namespace ASP_Framework4_6_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // use target typed new CA
            Shared1 sh = new Shared1();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}