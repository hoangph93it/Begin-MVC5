using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoFirstAppMVC.Models;

namespace DemoFirstAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int get_hour = DateTime.Now.Hour;
            ViewBag.Get_Hour = get_hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestRespone guest_respone)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guest_respone);
            }
            else
            {
                return View();
            }

        }
    }
}