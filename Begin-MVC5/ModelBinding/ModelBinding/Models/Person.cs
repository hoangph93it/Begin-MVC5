using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public Genders Gender { get; set; }
        public Addresss Address { get; set; }
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
    public class Addresss
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

}