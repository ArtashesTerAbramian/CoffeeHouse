using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DTO.ProvinceDtos;

namespace CoffeeHouse.BLL.Services.ProvinceService;

public interface IProvinceService
{
    Task<PagedResult<List<ProvinceDto>>> GetAll(ProvinceFilter filter);
    Task<Result<ProvinceDto>> GetById(long id);
}
