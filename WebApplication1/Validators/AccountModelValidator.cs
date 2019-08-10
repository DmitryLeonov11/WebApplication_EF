using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Validators
{
    public class AccountModelValidator : AbstractValidator<AccountModel>
    {
        public AccountModelValidator()
        {
            RuleFor(_=>_.Balance).NotNull().GreaterThan(-1);
            RuleFor(_=>_.ClientId).GreaterThan(-1).NotNull();
        }
    }
}