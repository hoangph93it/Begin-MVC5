using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_MVC_Razor.Models;

namespace View_MVC_Razor.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudent()
        {
            IList<Student> listStudent = new List<Student>();
            listStudent.Add(new Student() { StudentID = 1, StudentName = "Phan Huu Hoang", Age = 24, Address = "Ha Noi" });
            listStudent.Add(new Student() { StudentID = 2, StudentName = "Tran Kim Phuoc", Age = 22, Address = "Vinh Phuc" });
            listStudent.Add(new Student() { StudentID = 3, StudentName = "Do Viet Thuong", Age = 25, Address = "Thanh Hoa" });
            listStudent.Add(new Student() { StudentID = 4, StudentName = "Hoang Minh Duc", Age = 23, Address = "Nghe An" });
            ViewData["listStudent"] = listStudent;
            return View();
        }
        public ActionResult UsingViewBag()
        {
            ViewBag.Message = "Hello ViewBag";
            ViewBag.Today = DateTime.Now;
            return View();
        }
    }
}