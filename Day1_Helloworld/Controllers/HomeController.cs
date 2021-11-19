using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_Helloworld.Controllers
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

        [ActionName("ContactUs")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return Redire
        }

        [NonAction]
        public string getSampleName()
        {
            return "generated from DB";
        }
    }
}