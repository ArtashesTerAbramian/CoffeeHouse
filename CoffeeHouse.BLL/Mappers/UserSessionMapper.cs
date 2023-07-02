using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.UsersDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class UserSessionMapper
{
    public static partial UserSessionDto MapToUserSessionDto(this UserSession user);
}