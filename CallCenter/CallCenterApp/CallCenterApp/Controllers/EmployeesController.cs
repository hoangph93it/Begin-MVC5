using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CallCenterApp.DataAccess;
using CallCenterApp.Models;
namespace CallCenterApp.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeesDB emp_db = new EmployeesDB();
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(emp_db.ListAllEmployee(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetById(string empID)
        {
            var emp = emp_db.ListAllEmployee().Find(em => em.EmployeeID.Equals(empID));
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(Employees emp)
        {
            return Json(emp_db.AddEmployee(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(string empID)
        {
            return Json(emp_db.DeleteEmployee(empID), JsonRequestBehavior.AllowGet);
        }
    }
}