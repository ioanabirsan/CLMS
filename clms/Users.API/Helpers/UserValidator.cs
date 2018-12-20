﻿using FluentValidation;
using Users.API.Models;

namespace Users.API.Helpers
{
//    https://cecilphillip.com/fluent-validation-rules-with-asp-net-core/
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name).NotNull().Matches("[A-Z][a-z'-]+[ ][A-Z.][ ][A-Z][a-z'-]");
            RuleFor(user => user.Phone).NotNull().Matches("(00|\\+)40\\d{10}");
            RuleFor(user => user.Email).NotNull().Matches("[a-zA-Z0-9_.-]+@[a-z]+.[a-z]+");
            RuleFor(user => user.Password).NotNull().Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$");
        }
    }
}