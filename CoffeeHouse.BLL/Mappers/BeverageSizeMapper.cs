using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class BeverageSizeMapper
{
    public static BeverageSizeDto MapBeverageSizeDto(this BeverageSize province)
    {
        var dto = BeverageSizeToBeverageSizeDto(province);

        dto.Size = province.Translations.First().Size;

        return dto;
    }

    private static partial BeverageSizeDto BeverageSizeToBeverageSizeDto(BeverageSize province);
}
