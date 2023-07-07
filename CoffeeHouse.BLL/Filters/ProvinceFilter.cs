using CoffeeHouse.DAL.Models;

namespace CoffeeHouse.BLL.Filters;

public class ProvinceFilter : BaseFilter<Province>
{
    public string? Name { get; set; }
    public override IQueryable<Province> CreateQuery(IQueryable<Province> query)
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
