using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxHelperMVC.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Genders Gender { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public Roles Role { get; set; }
    }
    public enum Genders
    {
        Mail,
        Femail
    }
    public enum Roles
    {
        Admin,
        User,
        Guest
    }
}