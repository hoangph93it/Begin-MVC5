using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateHelpMethod.Models;
using TemplateHelpMethod.Interface;
using TemplateHelpMethod.Implement;

namespace TemplateHelpMethod.Controllers
{
    public class HomeController : Controller
    {
        private IPersons List_Persons = new EPersons();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult AllPersons()
        {
            IList<Person> listPersons = List_Persons.GetAllPersons();
            return View(listPersons);
        }
        public ActionResult CreatePersons()
        {
            IList<Person> listPerson = new List<Person>();

            return View(new Person());

        }
        [HttpPost]
        public ActionResult CreatePersons(Person persons)
        {
            return View(persons);
        }
    }
}