using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DTO.UsersDtos;

namespace CoffeeHouse.BLL.Services.UserService;

public interface IUserService
{
    Task<Result> AddUserAsync(AddUserDto dto);
    Task<Result> Delete(long Id);
    Task<PagedResult<List<UserDto>>> GetAllAsync(UserFilter filter);
    Task<Result<UserDto>> GetByIdAsync(long id);
    Task<Result<UserDto>> GetUserByUsernameAsync(string username);
    Task<Result> UpdateAsync(UpdateUserDto dto);
}