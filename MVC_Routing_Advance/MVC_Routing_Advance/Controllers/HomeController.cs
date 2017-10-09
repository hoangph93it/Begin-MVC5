using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Routing_Advance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Controller = "Controller Home";
            ViewBag.Action = "Action Home";
            ViewBag.ControllerContent = "This text is the content of Controller Home.";
            return View();
        }
        public ActionResult CustomController()
        {
            ViewBag.Controller = "Controller Custom";
            ViewBag.Action = "Action Custom";
            ViewBag.ControllerCustomContent = "This text is the content of Controller Custom.";
            return View();
        }
        public ViewResult MyActionMethod()
        {
            string myActionUrl = Url.Action("Index", new { id = "HoangPH" });
            string myRouteUrl = Url.RouteUrl(new { controller = "Customer", action = "Index", id = "HoangPH" });
            ViewBag.UrlAction = myActionUrl;
            ViewBag.UrlRoute = myRouteUrl;
            return View();
        }
        //public RedirectToRouteResult MyActionMethod()
        //{
        //    return RedirectToAction("CustomController");
        //}
    }
}