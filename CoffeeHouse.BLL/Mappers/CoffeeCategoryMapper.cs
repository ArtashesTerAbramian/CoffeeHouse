using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.CoffeeCategoryDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class CoffeeCategoryMapper
{
    public static CoffeeCategoryDto MapCoffeeCategoryDto(this CoffeeCategory category)
    {
        var dto = CoffeeCategoryToCoffeeCategoryDto(category);

        dto.Name = category.Translations.First().Name;

        return dto;
    }

    private static partial CoffeeCategoryDto CoffeeCategoryToCoffeeCategoryDto(CoffeeCategory category);
    public static partial List<CoffeeCategoryDto> MapToCoffeeCategoriesDtos(this List<CoffeeCategory> categories);
}
