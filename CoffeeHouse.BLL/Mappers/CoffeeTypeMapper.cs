using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeTypeDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class CoffeeTypeMapper
{
    public static CoffeeTypeDto MapCoffeeTypeDto(this CoffeeType type)
    {
        var dto = CoffeeTypeToCoffeeTypeDto(type);

        dto.Name = type.Translations.First().Name;

        return dto;
    }

    private static partial CoffeeTypeDto CoffeeTypeToCoffeeTypeDto(CoffeeType type);
    public static partial List<CoffeeTypeDto> MapToCoffeeTypesDtos(this List<CoffeeType> types);
}
