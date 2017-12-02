using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CrudMVCSingleStore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Must be enter the name")]
        [StringLength(15, ErrorMessage = "Name should be less than or equal to 15 character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Must be enter the customer address")]
        [StringLength(50, ErrorMessage = "Address should be less than or equal to 50 character")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must be provide a phone number")]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid the phone number")]
        public string Mobileno { get; set; }
        [Required(ErrorMessage = "Must be enter the birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Must be enter email")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter the valid email")]
        [CrudMVCSingleStore.Models.CustomValidationAttributeDemo.ValidBirthDate(ErrorMessage ="Birth date can not be greater than current date")]
        public string EmailID { get; set; }
        public List<Customer> ShowallCus { get; set; }
    }
}