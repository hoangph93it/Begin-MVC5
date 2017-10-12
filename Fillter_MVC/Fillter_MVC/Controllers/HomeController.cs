using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fillter_MVC.Infrastructure;

namespace Fillter_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [CustomAuth(false)]
        public ActionResult Index()
        {
            return View();
        }
    }
}