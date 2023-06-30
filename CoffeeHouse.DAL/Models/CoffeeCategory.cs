using CoffeeHouse.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Models
{
    public class CoffeeCategory : BaseEntity
    {
        public CoffeeCategory()
        {
            Translations = new HashSet<CoffeeCategoryTranslation>();
        }
        public CoffeeCategoryEnum CoffeeCategoryEnum { get; set; }
        public ICollection<CoffeeCategoryTranslation> Translations { get; set; }
    }
}
