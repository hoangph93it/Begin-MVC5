using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LamviecvoiRazor.Models;
namespace LamviecvoiRazor.Controllers
{
    public class HomeController : Controller
    {
        Product my_prod = new Product
        {
            ProductId = 1,
            ProductName = "Smart Phone",
            Description = "The best smartphone",
            Price = 800,
            Category = "T1"
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(my_prod);
        }
        public ActionResult NameAndPrice()
        {
            return View(my_prod);
        }
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(my_prod);
        }
        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Smart Phone",
                    Description = "The best smartphone",
                    Price = 800,
                    Category = "T1"
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "TV",
                    Description = "The best TV",
                    Price = 400,
                    Category = "T2"
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Refrigerator",
                    Description = "The best Refrigerator",
                    Price = 600,
                    Category = "T3"
                }
            };
            return View(array);
        }
    }
}