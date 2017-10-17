using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethodMVC.Models;

namespace HelperMethodMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Cities = new string[] { "Ha Noi", "Ho Chi Minh", "Vinh Phuc", "Thanh Hoa" };
            ViewBag.Elictrics = new string[] { "Tivi", "Tu lanh", "May giat", "May loc nuoc", "Dieu hoa" };
            string message = "This is HTML element: <input>";
            return View((object)message);
        }
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult CreatePerson(Person person)
        {
            return View(person);
        }
    }
}