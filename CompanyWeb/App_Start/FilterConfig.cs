﻿using CompanyWeb.Helpers;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
         //   filters.Add(new MyCustomAttribute());
        }
    }
}