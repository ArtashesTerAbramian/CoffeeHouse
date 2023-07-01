using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DTO.CoffeeTypeDtos
{
    public class UpdateCoffeeTypeDto
    {
        public long Id { get; set; }
        public List<CoffeeTypeTranslationDto> Translations { get; set; }
    }
}
