using CoffeeHouse.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DTO.CoffeeDtos
{
    public class UpdateCoffeeDto
    {
        public long Id { get; set; }
        public long? CoffeeTypeId { get; set; }
        public List<CoffeeTranslationDto> Translations { get; set; }
        public FileDto? Photo { get; set; }
    }
}
