using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Filters
{
    public class CoffeeTypeFilter : BaseFilter<DAL.Models.CoffeeType>
    {
        public string? Name { get; set; }
        public override IQueryable<DAL.Models.CoffeeType> CreateQuery(IQueryable<DAL.Models.CoffeeType> query)
        {
            if(Query != null)
            {
                return Query;
            }

            if(!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(x => x.Translations.Any(x => x.Name.ToLower().Contains(Name.ToLower())));
            }

            return query;
        }
    }
}
