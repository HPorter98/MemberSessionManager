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
                .Length(2, 50)
                .Must(ValidName);

            RuleFor(member => member.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50)
                .Must(ValidName);

            RuleFor(member => member.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50);

        }

        protected bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }
    }
}
