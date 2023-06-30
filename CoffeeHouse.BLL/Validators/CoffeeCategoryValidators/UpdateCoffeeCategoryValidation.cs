using CoffeeHouse.DTO.CoffeeTypeDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Validators.CoffeeCategoryValidators
{
    public class UpdateCoffeeCategoryValidation : AbstractValidator<UpdateCoffeeTypeDto>
    {
        public UpdateCoffeeCategoryValidation()
        {
            RuleForEach(x => x.Translations)
                .ChildRules(name =>
                    name.RuleFor(x => x.Name)
                        .NotEmpty()
                        .WithMessage("{CollectionIndex} cant be empty"));
        }
    }
}
