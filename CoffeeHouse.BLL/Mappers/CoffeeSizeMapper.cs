using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class CoffeeSizeMapper
{
    public static CoffeeSizeDto MapCoffeeSizeDto(this CoffeeSize province)
    {
        var dto = CoffeeSizeToCoffeeSizeDto(province);

        dto.Size = province.Translations.First().Size;

        return dto;
    }

    private static partial CoffeeSizeDto CoffeeSizeToCoffeeSizeDto(CoffeeSize province);
}
