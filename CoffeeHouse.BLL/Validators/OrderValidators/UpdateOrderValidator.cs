using CoffeeHouse.DTO.OrderDtos;
using FluentValidation;

namespace CoffeeHouse.BLL.Validators.OrderValidators;

public class UpdateOrderValidator : AbstractValidator<UpdateOrderDto>
{
    public UpdateOrderValidator()
    {
        
    }
}
