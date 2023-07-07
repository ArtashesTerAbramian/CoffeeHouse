using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.ProvinceDtos;
using Riok.Mapperly.Abstractions;

namespace CoffeeHouse.BLL.Mappers;

[Mapper]
public static partial class ProvinceMapper
{
    public static ProvinceDto MapProvinceDto(this Province province)
    {
        var dto = ProvinceToProvinceDto(province);

        dto.Name = province.Translations.First().Name;

        return dto;
    }

    private static partial ProvinceDto ProvinceToProvinceDto(Province province);
    public static partial List<ProvinceDto> MapToProvincesDtos(this List<Province> provinces);
}
