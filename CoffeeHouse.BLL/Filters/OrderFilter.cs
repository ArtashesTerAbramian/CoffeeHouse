﻿using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.BLL.Filters;

public class OrderFilter : BaseFilter<Order>
{
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public long? UserId { get; set; }
    public decimal? StartFromPrice { get; set; }
    public decimal? UpToPrice { get; set; }

    public override IQueryable<Order> CreateQuery(IQueryable<Order> query)
    {
        if(Query != null)
        {
            return  Query;
        }

        if (FromDate != null)
        {
            query = query.Where(x => x.CreatedDate > FromDate);
        }

        if(ToDate != null)
        {
            query = query.Where(x => x.CreatedDate < ToDate);
        }

        if(UserId.HasValue && UserId > 0)
        {
            query = query.Where(x => x.UserId == UserId);
        }

        if(StartFromPrice.HasValue && StartFromPrice > 0)
        {
            query = query.Where(x => x.TotalPrice > StartFromPrice);
        }


        if (UpToPrice.HasValue && UpToPrice > 0)
        {
            query = query.Where(x => x.TotalPrice < UpToPrice);
        }

        return query;
    }
}