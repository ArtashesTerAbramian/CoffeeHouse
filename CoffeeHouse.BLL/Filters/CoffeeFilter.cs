﻿using CoffeeHouse.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Filters
{
    public class CoffeeFilter : BaseFilter<Coffee>
    {
        public string? Name { get; set; }
        public override IQueryable<Coffee> CreateQuery(IQueryable<Coffee> query)
        {
            if(Query != null)
            {
                return Query;
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                query = query.Where(x => x.Translations.Any(x => x.Name.ToLower().Contains(Name.ToLower())));
            }

            return query;
        }
    }
}
