using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CoffeeCategoryConfiguration : BaseConfiguration<CoffeeCategory>
{
    public override void Configure(EntityTypeBuilder<CoffeeCategory> builder)
    {
        base.Configure(builder);

        builder.ToTable("coffee_category");
    }
}
