using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DTO.AddressDtos;

namespace CoffeeHouse.BLL.Services.AddressService;

public interface IAddressService
{
    Task<PagedResult<List<AddressDto>>> GetAll(AddressFilter filter);
    Task<Result<AddressDto>> GetById(long id);
}