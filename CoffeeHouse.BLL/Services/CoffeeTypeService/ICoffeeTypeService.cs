using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeTypeDtos;

namespace CoffeeHouse.BLL.Services.CoffeeCategoryService;

public interface ICoffeeTypeService
{
    Task<Result> Add(AddCoffeeTypeDto dto);
    Task<Result<CoffeeTypeDto>> GetById(long Id);
    Task<PagedResult<List<CoffeeTypeDto>>> GetAll(CoffeeTypeFilter filter);
    Task<Result> Update(UpdateCoffeeTypeDto dto);
    Task<Result> Delete(long id);
}
