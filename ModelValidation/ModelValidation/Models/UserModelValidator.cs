using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;

namespace ModelValidation.Models
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(u => u.Name).NotNull();
            RuleFor(u => u.Email).NotNull().EmailAddress();
            RuleFor(u => u.PhoneNo).NotNull().Length(10, 11);
        }
    }
}