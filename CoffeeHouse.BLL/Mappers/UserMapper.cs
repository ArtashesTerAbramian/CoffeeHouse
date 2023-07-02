using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.UsersDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class UserMapper
{
    public static partial UserDto MapToUserDto(this User user);
    public static partial List<UserDto> MapToUsersDtos(this List<User> user);
}