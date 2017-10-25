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
            new Person { ID = 2, Name = "Tran Kim Phuoc", Gender = Genders.Femail, DOB = "27/01/1997", Address = "Vinh Tuong -  Vinh Phuc", Role = Roles.User},
            new Person { ID = 3, Name = "Do Viet Thuong", Gender = Genders.Mail, DOB = "20/11/1993", Address = "Thieu Hoa -  Thanh Hoa", Role = Roles.Guest},
            new Person { ID = 4, Name = "Hoang Trung Duc", Gender = Genders.Femail, DOB = "07/10/1994", Address = "Thieu Hoa -  Thanh Hoa", Role = Roles.Guest}
        };
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult GetPeople()
        //{
        //    return View(personData);
        //}
        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{
        //    if (selectedRole == null || selectedRole == "All")
        //    {
        //        return View(personData);
        //    }
        //    else
        //    {
        //        Roles selected = (Roles)Enum.Parse(typeof(Roles), selectedRole);
        //        ViewData["Roleselected"] = selected;
        //        return View(personData.Where(p => p.Role == selected));
        //    }
        //}
        private IEnumerable<Person> GetData(string selectedRole)
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Roles selected = (Roles)Enum.Parse(typeof(Roles), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return data;
        }
        public JsonResult GetPeopleDataJson(string selectedRole = "All")
        {
            IEnumerable<Person> data = GetData(selectedRole);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Roles selected = (Roles)Enum.Parse(typeof(Roles), selectedRole);
                ViewData["Roleselected"] = selected;
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
    }
}