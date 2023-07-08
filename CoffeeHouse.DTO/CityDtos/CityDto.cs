using CoffeeHouse.Dto;
using CoffeeHouse.DTO.ProvinceDtos;

namespace CoffeeHouse.DTO.CityDtos;

public class CityDto : BaseDto
{
    public string Name { get; set; }
    public ProvinceDto Province { get; set; }
}