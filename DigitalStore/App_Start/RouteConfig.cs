﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DigitalStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Contact",
               url: "lien-he",
               defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "DigitalStore.Controllers" }
           );
            routes.MapRoute(
                name: "Game",
                url: "the-loai",
                defaults: new { controller = "Games", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "DigitalStore.Controllers" }
            );
            routes.MapRoute(
                name: "GameGenre",
                url: "the-loai-game/{alias}-{id}",
                defaults: new { controller = "Games", action = "GameGenre", id = UrlParameter.Optional },
                namespaces: new[] { "WebsiteBanDTOnline.Controllers" }
            );
            routes.MapRoute(
               name: "Home",
               url: "trang-chu",
               defaults: new { controller = "Home", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "DigitalStore.Controllers" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DigitalStore.Controllers" }
            );
        }
    }
}
