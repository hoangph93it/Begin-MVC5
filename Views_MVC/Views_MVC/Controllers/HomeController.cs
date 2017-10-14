using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Hello Views in ASP.NET MVC";
            ViewBag.Time = DateTime.Now.ToShortTimeString();
            return View("DebugData");
        }
        public ActionResult List()
        {
            return View();
        }
    }
}