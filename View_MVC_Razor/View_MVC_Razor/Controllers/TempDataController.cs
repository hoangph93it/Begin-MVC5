using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_MVC_Razor.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["Name"] = "Phan Huu Hoang";
            TempData["Address"] = "Tuan Chinh - Vinh Tuong - Vinh Phuc";
            return Redirect("TempData/About");
        }
        public ActionResult About()
        {
            if ((TempData["Name"] != null) && (TempData["Name"] != null))
            {
                return View();
            }
            else
            {
                return View("TempData not found.");
            }
        }
    }
}