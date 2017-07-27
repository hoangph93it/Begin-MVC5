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
        public ViewResult UseExtensionIEnum()
        {
            IEnumerable<Product> product = new ShoppingCart
            {
                Products = new List<Product>
                {
                 new Product {Name="Dieu hoa", Price=1000, Category= "C1" },
                 new Product {Name="Tu lanh", Price=1000,Category= "C2" },
                 new Product {Name="Tivi", Price=1000,Category= "C3" }
                }
            };
            Product[] arrProduct =
            {
                 new Product {Name="Dien thoai", Price=3000 },
                 new Product {Name="May loc nuoc", Price=3000 },
                 new Product {Name="Binh nong lanh", Price=3000 }
            };
            Func<Product, bool> categortyFilter = delegate (Product prod)
             {
                 return prod.Category == "C1";
             };
            Func<Product, bool> categoryFilter2 = prod => prod.Category == "C1";

            decimal cartTotal = product.TotalPrices();
            decimal arrTotal = product.TotalPrices();
            ViewBag.CartTotal = cartTotal;
            ViewBag.ArrTotal = arrTotal;
            decimal fil_res = 0;
            foreach (Product prod in product.Fillter(prod => prod.Category == "C1" || prod.Price > 20))
            {
                fil_res += prod.Price;
            }
            foreach (Product prod in product.FilterByCategory("C1"))
            {
                fil_res = prod.Price;
            };
            var takeProduct = product.OrderByDescending(p => p.Price).Take(3).Select(p => new { p.Price, p.Name });
            ViewBag.FilterCategory = fil_res;
            return View();
        }
    }
}