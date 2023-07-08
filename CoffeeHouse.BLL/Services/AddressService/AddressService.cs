using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DTO.AddressDtos;
using CoffeeHouse.DTO.CityDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.AddressService;

public class AddressService : IAddressService
{
    private readonly AppDbContext _db;

    public AddressService(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<PagedResult<List<AddressDto>>> GetAll(AddressFilter filter)
    {
        var query = _db.Addresses
            .Include(x => x.Translations);

        var addresses = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<AddressDto>>(await filter.GetPagedInfoAsync(query), addresses.MapToAddressDtos());
    }

    public async Task<Result<AddressDto>> GetById(long id)
    {
        var address = await _db.Addresses.FirstOrDefaultAsync(x => x.Id == id);

        if (address == null)
        {
            return Result.NotFound();
        }

        return address.MapProvinceDto();
    }
}