using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controller_Action.Abstract
{
    public interface IproductRepository
    {
        IList<Models.Product> GetAllProduct();
        IList<Models.Product> GetProductByName(string pro_name);
        Models.Product GetProductById(int pro_id);
    }
}