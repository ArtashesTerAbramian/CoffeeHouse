
using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DTO.CoffeeCategoryDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.CoffeeCategoryService;

public class CoffeeCategoryService : ICoffeeCategoryService
{
    private readonly AppDbContext _db;

    public CoffeeCategoryService(AppDbContext db)
    {
        _db = db;
    }
    public Task<Result> Add(AddCoffeeCategoryDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Delete(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResult<List<CoffeeCategoryDto>>> GetAll(CoffeeCategoryFilter filter)
    {
        var query = _db.CoffeeCategories
            .Include(x => x.Translations);

        var categories = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<CoffeeCategoryDto>>(await filter.GetPagedInfoAsync(query), categories.MapToCoffeeCategoriesDtos());
    }

    public Task<Result<CoffeeCategoryDto>> GetById(long Id)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Update(UpdateCoffeeCategoryDto dto)
    {
        throw new NotImplementedException();
    }
}
