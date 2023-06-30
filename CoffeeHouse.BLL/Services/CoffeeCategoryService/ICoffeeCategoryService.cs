using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeCategoryDtos;

namespace CoffeeHouse.BLL.Services.CoffeeCategoryService;

public interface ICoffeeCategoryService
{
    Task<Result> Add(AddCoffeeCategoryDto dto);
    Task<Result<CoffeeCategoryDto>> GetById(long Id);
    Task<PagedResult<List<CoffeeCategoryDto>>> GetAll(CoffeeCategoryFilter filter);
    Task<Result> Update(UpdateCoffeeCategoryDto dto);
    Task<Result> Delete(long id);
}
