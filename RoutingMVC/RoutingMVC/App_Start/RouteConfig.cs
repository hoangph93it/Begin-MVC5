using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;

namespace RoutingMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            // routes.MapRoute("MyRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "DefaultId" });
            // routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new { controller = "^H.*", action = "Index/About", httpMethod = new HttpMethodConstraint("GET"), id = new RangeRouteConstraint(10, 20) }, new[] { "RoutingMVC.ControllersAdditional" });
            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new { controller = "^H.*", action = "Index/About", httpMethod = new HttpMethodConstraint("GET"), id = new CompoundRouteConstraint(new IRouteConstraint[] { new AlphaRouteConstraint(), new MinLengthRouteConstraint(8) }) }, new[] { "RoutingMVC.ControllersAdditional" });
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new { controller = "^H.*" }, new[] { "RoutingMVC.ControllersAdditional" });
            //routes.MapRoute("AddMyRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new[] { "RoutingMVC.Controllers" });
            //routes.MapRoute("", "X{controller}/{action}");
            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);
            //routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
            //routes.MapRoute("", "{controller}/{action}", new { controller = "Home", action = "Index" });
            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

        }
        //public class RoutesConfig
        //{
        //    public static void RegisterRoutes(RouteCollection routes)
        //    {
        //        routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
        //    }
        //}
    }
}
