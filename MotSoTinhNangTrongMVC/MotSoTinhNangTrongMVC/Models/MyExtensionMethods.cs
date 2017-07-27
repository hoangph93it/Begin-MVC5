using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotSoTinhNangTrongMVC.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product prod in productEnum)
            {
                total += prod.Price;
            }
            return total;
        }
        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryEnum)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == categoryEnum)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> Fillter(this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}