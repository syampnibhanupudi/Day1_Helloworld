﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_Helloworld.Controllers
{
    public class ClinicController : Controller
    {
        // GET: Clinic
        public ActionResult Index(int id)
        {
            return View();
        }

        
    }
}