using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotSoTinhNangTrongMVC.Models
{
    public class Product
    {

        //private int productId;
        //private string name;
        //private string desciption;
        //public int ProductId
        //{
        //    get { return productId; }
        //    set { productId = value; }
        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public string Description
        //{
        //    get { return desciption; }
        //    set { desciption = value; }
        //}
        // => nên viết lại như sau:
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}