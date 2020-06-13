using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace programmirovanje
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Books", action = "List", id = UrlParameter.Optional }
);

            routes.MapRoute(null, "", new
            {
                controller = "Game",
                action = "List",
                category = (string)null,
            }
        );

            routes.MapRoute(null,
            "{category}",
            new { controller = "Game", action = "List", page = 1 }
        );
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
