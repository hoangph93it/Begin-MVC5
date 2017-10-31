using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelValidation.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please enter correct email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number.")]
        [Display(Name = "Phone Number")]
        [StringLength(10, ErrorMessage = "The phone must be contains 10 characters")]
        public string PhoneNo { get; set; }
    }
}