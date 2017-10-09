using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Routing_Advance.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminAbout()
        {
            ViewBag.Controller = "Controller Admin About";
            ViewBag.Action = "Action admin";
            ViewBag.ContentAbout = "This text is a content of About page";
            return View();
        }
    }
}