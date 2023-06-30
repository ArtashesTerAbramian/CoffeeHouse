using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Helpers;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DTO.CoffeeDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.CoffeeService;

public class CoffeeService : ICoffeeService
{
    private readonly AppDbContext _db;
    private readonly FileHelper _fileHelper;

    public CoffeeService(AppDbContext db,
        FileHelper fileHelper)
    {
        _db = db;
        _fileHelper = fileHelper;
    }
    public Task<Result> Add(AddCoffeeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Delete(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResult<List<CoffeeDto>>> GetAll(CoffeeFilter filter)
    {
        var query = _db.Coffee
            .Include(x => x.Translations)
            .Include(x => x.Files);

        var coffees = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<CoffeeDto>>(await filter.GetPagedInfoAsync(query), coffees.MapToCoffeesDtos());
    }

    public Task<Result<CoffeeDto>> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Update(UpdateCoffeeDto dto)
    {
        throw new NotImplementedException();
    }
}
