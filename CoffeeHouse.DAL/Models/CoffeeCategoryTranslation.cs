using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class CoffeeCategoryTranslation : BaseTranslationEntity
    {
        public long CoffeeCategoryId { get; set; }
        public string Name { get; set; }

        public CoffeeCategory CoffeeCategory { get; set; }
    }
}
