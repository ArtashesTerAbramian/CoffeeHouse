﻿using CoffeeHouse.Dto;

namespace CoffeeHouse.DTO.CoffeeDtos;

public class CoffeeDto : BaseDto
{
    public long? CoffeeTypeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<CoffeePhotoDto> Files { get; set; }
}
