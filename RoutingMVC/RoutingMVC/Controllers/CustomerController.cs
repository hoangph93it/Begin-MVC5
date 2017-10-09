using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            ViewBag.TheVualue = "This text is value of Controller.";
            return View();
        }
        //[Route("User/Add/{user}/{id: int}")]
        //public string Create(string user, int id)
        //{
        //    return string.Format("User: {0},ID: {1}", user, id);
        //}
        [Route("User/Add/{user}/{password}")]
        public string ChangePassword(string user, string password)
        {
            return string.Format("Change password method: User: {0}, Password: {1}", user, password);
        }
        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
    }
}