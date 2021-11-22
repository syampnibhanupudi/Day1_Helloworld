using Day1_Helloworld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_Helloworld.Controllers
{
    [Log]
    public class ClinicController : Controller
    {
        // GET: Clinic
        //[OutputCache(Duration =10)]
        public ActionResult Index(int id)
        {
            ViewBag.today = DateTime.Now;
            //ViewData["UtcDate"] = DateTime.UtcNow;
            //TempData["Today"] = DateTime.Today;
            return View();
        }

        public ActionResult Index2()
        {
            string str = TempData.Peek("Today").ToString();
            
            return View();
        }
        public ActionResult Index3()
        {
            string str = TempData.Peek("Today").ToString();


            return View();
        }
    }
}