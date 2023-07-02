using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Helpers;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.UsersDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.UserService;

public class UserService: IUserService
{
    private readonly AppDbContext _db;
    private readonly PasswordHashHelper _passwordHashHelper;

    public UserService(AppDbContext db,
        PasswordHashHelper passwordHashHelper)
    {
        _db = db;
        _passwordHashHelper = passwordHashHelper;
    }
    
    public async Task<Result> AddUserAsync(AddUserDto dto)
    {
        
        var user = new User()
        {
            Email = dto.Email,
            UserName = dto.UserName.ToLower(),
            Phone = dto.Phone,
            PasswordHash = _passwordHashHelper.HashPassword(dto.Password)
        };

        await _db.Users.AddAsync(user);

        await _db.SaveChangesAsync();

        return Result.Success();
    }
    
    public async Task<PagedResult<List<UserDto>>> GetAllAsync(UserFilter filter)
    {
        var query = _db.Users;

        var users = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<UserDto>>(await filter.GetPagedInfoAsync(query), users.MapToUsersDtos());
    }

    public async Task<Result<UserDto>> GetByIdAsync(long id)
    {
        var user = _db.Users.FirstOrDefault(x => x.Id == id);

        if (user == null)
        {
            return Result.NotFound();
        }

        return user.MapToUserDto();
    }

    public async Task<UserDto> GetUserByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }


    public async Task<Result> UpdateAsync(UpdateUserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Delete(long Id)
    {
        throw new NotImplementedException();
    }
}