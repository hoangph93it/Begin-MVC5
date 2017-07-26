using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotSoTinhNangTrongMVC.Models;

namespace MotSoTinhNangTrongMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to Url to show an example";
        }
        public ViewResult AutoProperty()
        {
            Product my_pro = new Product();
            my_pro.Name = "Dieu hoa Nagakawa";
            string ProductName = my_pro.Name;
            ViewBag.NamePro = ProductName;
            return View();
            //return View("Result", (object)String.Format("ProuctName:{0}", ProductName));
        }
        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart()
            {
                Products = new List<Product>{
                 new Product {Name="Dieu hoa", Price=1000 },
                 new Product {Name="Tu lanh", Price=1000 },
                 new Product {Name="Tivi", Price=1000 }
                }
            };
            decimal cartTotal = cart.TotalPrices();
            ViewBag.TotalCart = cartTotal;
            return View();
        }
    }
}