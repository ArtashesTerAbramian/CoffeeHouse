
using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DTO.CoffeeTypeDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.CoffeeCategoryService;

public class CoffeeCategoryService : ICoffeeCategoryService
{
    private readonly AppDbContext _db;

    public CoffeeCategoryService(AppDbContext db)
    {
        _db = db;
    }
    public Task<Result> Add(AddCoffeeTypeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Delete(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResult<List<CoffeeTypeDto>>> GetAll(CoffeeCategoryFilter filter)
    {
        var query = _db.CoffeeTypes
            .Include(x => x.Translations);

        var types = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<CoffeeTypeDto>>(await filter.GetPagedInfoAsync(query), types.MapToCoffeeTypesDtos());
    }

    public Task<Result<CoffeeTypeDto>> GetById(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Update(UpdateCoffeeTypeDto dto)
    {
        throw new NotImplementedException();
    }
}
