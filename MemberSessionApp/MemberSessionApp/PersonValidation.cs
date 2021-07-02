using System;
using FluentValidation;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MemberSessionApp
{
    class PersonValidation: AbstractValidator<Member>
    {
        public PersonValidation()
        {
            RuleFor(member => member.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50).WithMessage("{PropertyName} length is invalid")
                .Must(IsValidName).WithMessage("Invalid name");

            RuleFor(member => member.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50).WithMessage("{PropertyName} length is invalid")
                .Must(IsValidName).WithMessage("Invalid name");

            RuleFor(member => member.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50).WithMessage("{PropertyName} length is invalid");

            RuleFor(member => member.PostCode)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 10).WithMessage("{PropertyName} length is invalid");

            RuleFor(member => member.ContactNum)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Must(IsValidNumber).WithMessage("Number is invalid")
                .Length(11, 15).WithMessage("{PropertyName} must be 11-15 digits");
                

            RuleFor(member => member.EmergencyNum)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Must(IsValidNumber).WithMessage("Number is invalid")
                .Length(11, 15).WithMessage("{PropertyName} must be 11-15 digits");
                

        }

        protected bool IsValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }

        protected bool IsValidNumber(string number)
        {
            number = number.Replace(" ", string.Empty);
            number = number.Replace("-", string.Empty);
            number = number.Replace("(", string.Empty);
            number = number.Replace(")", string.Empty);
            number = number.Replace("+", string.Empty);
            return number.All(char.IsDigit);
        }
    }
}
