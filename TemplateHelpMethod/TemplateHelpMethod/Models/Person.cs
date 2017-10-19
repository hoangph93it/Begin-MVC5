using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateHelpMethod.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public Address HomeAddress { get; set; }
        public Roles Role { get; set; }
    }
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
    public enum Roles
    {
        Admin, User, Guest
    }
}