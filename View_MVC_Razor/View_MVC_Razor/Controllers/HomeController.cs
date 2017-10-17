using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_MVC_Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string[] fruits = { "Orange", "Apple", "Pear", "Tomato" };

            return View(fruits);
        }
        public ActionResult List()
        {
            ViewData["Name"] = "Phan Huu Hoang";
            ViewData["Job"] = "Coder";
            return View();
        }
        public ActionResult About()
        {
            ViewData["Name"] = "Phan Huu Hoang";
            ViewData["Email"] = "hoangse.vp@gmail.com";
            return View();
        }
        [ChildActionOnly]
        public ActionResult Time()
        {
            return PartialView(DateTime.Now);
        }
    }
}