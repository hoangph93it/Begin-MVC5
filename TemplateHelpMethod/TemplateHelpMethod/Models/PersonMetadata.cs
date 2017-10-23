using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TemplateHelpMethod.Models
{
    public partial class PersonMetadata
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Persion ID")]
        public int PersonID { get; set; }
        [Display(Name = "First Name")]
        [UIHint("MultilineText")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }
        [Display(Name = "Home Address")]
        public Address HomeAddress { get; set; }
        [Display(Name = "Role")]
        public Roles Role { get; set; }
    }
    public partial class AddressMetadata
    {
        [Display(Name = "Line Adderess 1")]
        public string Line1 { get; set; }
        [Display(Name = "Line Adderess 2")]
        public string Line2 { get; set; }
        [Display(Name = "City Name")]
        public string City { get; set; }
        [Display(Name = "Country Name")]
        public string Country { get; set; }
    }
}