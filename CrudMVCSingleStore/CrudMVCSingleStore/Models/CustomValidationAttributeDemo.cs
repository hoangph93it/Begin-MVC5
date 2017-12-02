using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudMVCSingleStore.Models
{
    public class CustomValidationAttributeDemo
    {
        public sealed class ValidBirthDate : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value!=null)
                {
                    DateTime _birthJoin = Convert.ToDateTime(value);
                    if (_birthJoin>DateTime.Now)
                    {
                        return new ValidationResult("Birth date cannot be  greater than current date.");
                    }
                }
                return ValidationResult.Success;
            }
        }
    }
}