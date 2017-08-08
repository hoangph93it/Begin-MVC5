using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web.ui
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(null, "", new { controller = "Bean", action = "ListBean", category = (string)null, page = 1 });
            routes.MapRoute(null, "Page{page}", new { controller = "Bean", action = "ListBean", category = (string)null }, new { page = @"\d+" });
            routes.MapRoute(null, "{category}", new { controller = "Bean", action = "ListBean", page = 1 });
            routes.MapRoute(null, "{category}/Page{page}", new { controller = "Bean", action = "ListBean" }, new { page = @"\d+" });
            routes.MapRoute(null, "{controller}/{action}");
            routes.MapRoute(name: "", url: "Page{page}", defaults: new { controller = "Bean", action = "ListBean" });
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new { controller = "Bean", action = "ListBean", id = UrlParameter.Optional });
        }
    }
}
