﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC10PMBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Bakery",
                url: "Bakery/Cake",
                defaults: new { controller = "New", action = "Index", Eid = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{Eid}",
                defaults: new { controller = "Home", action = "Index", Eid = UrlParameter.Optional }
            );
        }
    }
}
