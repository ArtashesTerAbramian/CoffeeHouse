using CoffeeHouse.DAL.Enums;
using CoffeeHouse.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DTO.CoffeeCategoryDtos
{
    public class CoffeeCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public CoffeeCategoryEnum CoffeeCategoryEnum { get; set; }
    }
}
