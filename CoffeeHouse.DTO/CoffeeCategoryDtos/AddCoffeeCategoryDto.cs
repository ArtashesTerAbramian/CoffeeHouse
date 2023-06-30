using CoffeeHouse.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DTO.CoffeeCategoryDtos
{
    public class AddCoffeeCategoryDto
    {
        public CoffeeCategoryEnum CoffeeCategoryEnum { get; set; }
        public List<CoffeeCategoryTranslationDto> Translations { get; set; }
    }
}
