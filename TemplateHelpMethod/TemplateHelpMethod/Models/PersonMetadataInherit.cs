using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TemplateHelpMethod.Models
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class PersonMetadataInherit
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public Address HomeAddress { get; set; }
        public Roles Role { get; set; }
    }
    public partial class AddressMetadataInherit
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}