using CoffeeHouse.DTO.OrderDtos;
using FluentValidation;

namespace CoffeeHouse.BLL.Validators.OrderValidators;

public class AddOrderValidator : AbstractValidator<AddOrderDto>
{
    public AddOrderValidator()
    {
        RuleFor(x => x.AddressId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.UserId)
            .NotNull()
            .NotEmpty();

        RuleFor(x => x.Coffees) 
            .NotNull()
            .NotEmpty();
    }
}
