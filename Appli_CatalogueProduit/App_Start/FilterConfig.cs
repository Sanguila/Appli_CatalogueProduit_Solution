﻿using System.Web;
using System.Web.Mvc;

namespace Appli_CatalogueProduit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
