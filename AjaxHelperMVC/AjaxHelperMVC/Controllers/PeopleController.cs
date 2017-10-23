using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxHelperMVC.Models;
namespace AjaxHelperMVC.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData = {
            new Person { ID = 1, Name = "Phan Huu Hoang", Gender = Genders.Mail, DOB = "18/08/1993", Address = "Vinh Tuong -  Vinh Phuc", Role = Roles.Admin },
            new Person { ID = 2, Name = "Tran Kim Phuoc", Gender = Genders.Femail, DOB = "27/01/1997", Address = "Vinh Tuong -  Vinh Phuc", Role = Roles.User}
        };
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPeople()
        {
            return View(personData);
        }
        [HttpPost]
        public ActionResult GetPeople(string selectedRole)
        {
            if (selectedRole == null || selectedRole == "All")
            {
                return View(personData);
            }
            else
            {
                Roles selected = (Roles)Enum.Parse(typeof(Roles), selectedRole);
                ViewData["Roleselected"] = selected;
                return View(personData.Where(p => p.Role == selected));
            }

        }
    }
}