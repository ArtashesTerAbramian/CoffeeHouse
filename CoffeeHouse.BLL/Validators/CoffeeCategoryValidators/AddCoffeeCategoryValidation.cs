﻿using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeTypeDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Validators.CoffeeCategoryValidators
{
    public class AddCoffeeCategoryValidation : AbstractValidator<AddCoffeeTypeDto>
    {
        public AddCoffeeCategoryValidation()
        {
            RuleForEach(x => x.Translations)
                .ChildRules(name =>
                    name.RuleFor(x => x.Name)
                        .NotEmpty()
                        .WithMessage("{CollectionIndex} cant be empty"));
        }
    }
}
