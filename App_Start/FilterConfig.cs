﻿using System.Web;
using System.Web.Mvc;

namespace Central_Dispatch_Prototype
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
