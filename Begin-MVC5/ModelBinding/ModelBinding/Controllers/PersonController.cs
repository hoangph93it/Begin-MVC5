using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding.Models;


namespace ModelBinding.Controllers
{
    public class PersonController : Controller
    {
        private Person[] dataPerson =
        {
            new Person {ID=1, Name="Phan Huu Hoang",DOB="18-08-1993",Gender= Genders.Mail, Role=Roles.Admin },
            new Person {ID=2, Name="Tran Kim Phuoc",DOB="27-01-1997",Gender= Genders.Femail, Role=Roles.User },
            new Person {ID=3, Name="Do Viet Thuong",DOB="02-02-1992",Gender= Genders.Mail,  Role=Roles.Guest },
            new Person {ID=4, Name="Hoang Thi Duc",DOB="12-03-1993",Gender= Genders.Mail, Role=Roles.Guest }
        };
        // GET: Person
        public ActionResult Index(int? id)
        {
            Person personItem = dataPerson.Where(p => p.ID == id).First();
            return View(personItem);
        }
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Index", model);
        }
        public ActionResult DisplaySummary([Bind(Prefix = "Address"/*, Exclude = "City"*/)]AddressSummary summary)
        {
            return View(summary);
        }
        public ActionResult Name(string[] names)
        {
            names = names ?? new string[0];
            return View(names);
        }
        public ActionResult Name(IList<string> names)
        {
            names = names ?? new List<string>();
            return View(names);
        }
        public ActionResult Address(IList<AddressSummary> address)
        {
            address = address ?? new List<AddressSummary>();
            return View(address);
        }
    }
}