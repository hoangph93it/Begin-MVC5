using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controller_Action.Abstract;
using Controller_Action.Concrete;
using Controller_Action.Models;

namespace Controller_Action.Controllers
{
    public class ProductController : Controller
    {
        private IproductRepository ProductList = new ProductRepository();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ListProduct()
        {
            IList<Product> Products = ProductList.GetAllProduct();
            return View(Products);
        }
        [ActionName("ProductDetail")]
        public ViewResult GetProductById(int id)
        {
            Product Product_ID = ProductList.GetProductById(id);
            return View(Product_ID);
        }
        [HttpGet]
        [ActionName("SearchProduct")]
        public ViewResult GetProductByName()
        {
            IList<Product> Products = ProductList.GetAllProduct();
            return View(Products);
        }
        [HttpPost]
        [ActionName("SearchProduct")]
        public ViewResult GetProductByName(string ProductName)
        {
            IList<Product> Products = ProductList.GetProductByName(ProductName);
            return View(Products);
        }
    }
}