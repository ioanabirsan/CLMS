﻿using System;
using System.Collections.Generic;
using FluentValidation;
using Users.API.Models;

namespace Users.API.Helpers
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            List<int> yearValues = new List<int>() {1, 2, 3};
            const string studyProgram = "(bachelor)|(master)";
            const string group = "[A-Z][1-9]";

            RuleFor(student => student.StudyProgram)
                .NotNull()
                .Matches(studyProgram)
                .WithMessage(errorMessage: "Example: master, bachelor");

            RuleFor(student => student.Year)
                .NotNull()
                .Must(student => yearValues.Contains(student))
                .WithMessage(errorMessage: "Please only use: " + String.Join(",", yearValues));

            RuleFor(student => student.Group)
                .NotNull()
                .Matches(group);
        }
    }
}