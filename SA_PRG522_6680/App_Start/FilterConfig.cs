﻿using System.Web;
using System.Web.Mvc;

namespace SA_PRG522_6680
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
