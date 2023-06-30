using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeTypeDtos;

namespace CoffeeHouse.BLL.Services.CoffeeCategoryService;

public interface ICoffeeCategoryService
{
    Task<Result> Add(AddCoffeeTypeDto dto);
    Task<Result<CoffeeTypeDto>> GetById(long Id);
    Task<PagedResult<List<CoffeeTypeDto>>> GetAll(CoffeeCategoryFilter filter);
    Task<Result> Update(UpdateCoffeeTypeDto dto);
    Task<Result> Delete(long id);
}
