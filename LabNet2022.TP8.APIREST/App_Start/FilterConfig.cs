﻿using System.Web;
using System.Web.Mvc;

namespace LabNet2022.TP8.APIREST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
