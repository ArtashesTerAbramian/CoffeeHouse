using CoffeeHouse.Dto;

namespace CoffeeHouse.DTO.CoffeeDtos;

public class AddCoffeeDto
{
    public long? CoffeeTypeId { get; set; }
    public List<CoffeeTranslationDto> Translations;
    public FileDto? File { get; set; }
}
