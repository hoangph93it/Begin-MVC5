using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controller_Action.Concrete;
using Controller_Action.Models;
using Controller_Action.Abstract;

namespace Controller_Action.Controllers
{
    public class HomeController : Controller
    {
        private IproductRepository ProductList = new ProductRepository();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}