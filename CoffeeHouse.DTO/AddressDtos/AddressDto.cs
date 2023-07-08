using CoffeeHouse.Dto;

namespace CoffeeHouse.DTO.AddressDtos;

public class AddressDto : BaseDto
{
    public long CityId { get; set; }
    public string? PostalCode { get; set; }
    public string Street { get; set; }
}