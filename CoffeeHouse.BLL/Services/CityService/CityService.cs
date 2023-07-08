using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DTO.CityDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.CityService;

public class CityService : ICityService
{
    private readonly AppDbContext _db;

    public CityService(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<Result<CityDto>> GetById(long id)
    {
        var city = await _db.Cities
            .Include(x => x.Translations)
            .Include(x => x.Province)
            .ThenInclude(x => x.Translations)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (city == null)
        {
            return Result.NotFound();
        }

        return city.MapProvinceDto();
    }

    public async Task<PagedResult<List<CityDto>>> GetAll(CityFilter filter)
    {
        var query = _db.Cities
            .Include(x => x.Translations)
            .Include(x => x.Province)
            .ThenInclude(x => x.Translations);

        var cities = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<CityDto>>(await filter.GetPagedInfoAsync(query), cities.MapToCityDtos());
    }
}