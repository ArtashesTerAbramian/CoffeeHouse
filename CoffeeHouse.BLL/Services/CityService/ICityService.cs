using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DTO.CityDtos;

namespace CoffeeHouse.BLL.Services.CityService;

public interface ICityService
{
    Task<Result<CityDto>> GetById(long id);
    Task<PagedResult<List<CityDto>>> GetAll(CityFilter filter);
}