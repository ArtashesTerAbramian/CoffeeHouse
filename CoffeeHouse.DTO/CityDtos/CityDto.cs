using CoffeeHouse.DTO.ProvinceDtos;

namespace CoffeeHouse.DTO.CityDtos;

public class CityDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ProvinceDto Province { get; set; }
}