using Ardalis.Result;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO;
using CoffeeHouse.DTO.UsersDtos;

namespace CoffeeHouse.BLL.Services.UserService;

public interface IUserSessionService
{
    Task<Result<UserSessionDto>> Add(LoginDto dto);
    Task<Result<bool>> Delete();
    Task<User> GetByToken(string token);
    Result<UserDto> GetUserCurrentInfo();
}