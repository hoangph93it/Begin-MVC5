using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Optimization;

namespace ModelValidation.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserModelState(UserModelState user_model)
        {
            if (string.IsNullOrEmpty(user_model.Name))
            {
                ModelState.AddModelError("Name", "Please enter the name.");
            }
            if (!string.IsNullOrEmpty(user_model.Email))
            {
                string emailRegex = @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$";
                Regex re = new Regex(emailRegex);//Represents an immutable regular expression.
                if (!re.IsMatch(user_model.Email))
                {
                    ModelState.AddModelError("Email", "Please enter correct email address.");
                }
            }
            if (string.IsNullOrEmpty(user_model.PhoneNo))
            {
                ModelState.AddModelError("PhoneNo", "Please enter the phone number.");
            }
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult ServerMeta(UserModel mRegister)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View();
            }
        }
    }
}