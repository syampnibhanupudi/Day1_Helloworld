﻿using System.Web;
using System.Web.Mvc;

namespace Day1_Helloworld
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
