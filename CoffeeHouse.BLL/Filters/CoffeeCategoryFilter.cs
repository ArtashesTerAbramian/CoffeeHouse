using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Filters
{
    public class CoffeeCategoryFilter : BaseFilter<CoffeeCategory>
    {
        public string? Name { get; set; }
        public CoffeeCategoryEnum? CoffeeCategory { get; set; }
        public override IQueryable<CoffeeCategory> CreateQuery(IQueryable<CoffeeCategory> query)
        {
            if(Query != null)
            {
                return Query;
            }

            if(!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(x => x.Translations.Any(x => x.Name.ToLower().Contains(Name.ToLower())));
            }

            if (CoffeeCategory.HasValue)
            {
                query = query.Where(x => x.CoffeeCategoryEnum == CoffeeCategory);
            }

            return query;
        }
    }
}
