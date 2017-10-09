using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Routing_Advance.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Controller = "Controller Customer";
            ViewBag.Action = "Action Customer";
            ViewBag.ControllerContent = "This text is the content of Controller Customer.";
            return View();
        }
    }
}