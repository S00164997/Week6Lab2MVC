﻿using System.Web;
using System.Web.Mvc;

namespace S00164997Rad2016Mvc1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
