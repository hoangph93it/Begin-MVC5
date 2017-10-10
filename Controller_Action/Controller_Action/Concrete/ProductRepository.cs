using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller_Action.Abstract;
using Controller_Action.Models;

namespace Controller_Action.Concrete
{
    public class ProductRepository : IproductRepository
    {
        private List<Product> Products = new List<Product>()
        {
             new Product()
             {
                ProductID=1,
                ProductName="TV",
                Price=10M,
                Description="Screen Touch"
             },
             new Product()
             {
                ProductID=2,
                ProductName="Tu lanh",
                Price=20M,
                Description="Screen Touch"
             },
             new Product()
             {
                ProductID=2,
                ProductName="May giat",
                Price=15M,
                Description="Touch"
             },
             new Product()
             {
                ProductID=1,
                ProductName="Dieu hoa",
                Price=11M,
                Description="Screen "
             }
        };
        public IList<Product> GetAllProduct()
        {
            var Products = this.Products.Select(p => p);
            return Products.ToList();
        }
        public Product GetProductById(int id)
        {
            Product Products = this.Products.Where(p => p.ProductID == id).FirstOrDefault();
            return Products;
        }
        public IList<Product> GetProductByName(string ProductName)
        {
            if (ProductName.Trim().Length == 0)
            {
                return this.Products.Select(p => p).ToList();
            }
            else
            {
                return this.Products.Where(p => p.ProductName.Contains(ProductName)).ToList();
            }
        }
    }
}