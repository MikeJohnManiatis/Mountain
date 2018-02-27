using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mountain
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Contact",
            url: "{controller}/{action}"
            );

            routes.MapRoute(
                name: "TmbdApiPaging",
                url: "TmbdApi/{title}/{page}",
                defaults: new { controller = "movie", action = "Index", title = "", page = "" }, 
                constraints: new { title = @"^[a-zA-Z]+$", page = @"^[0-9]+$" }
              
                );
            

        }


    }
}
