using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CoffeeSizeConfiguration : BaseConfiguration<CoffeeSize>
{
    public override void Configure(EntityTypeBuilder<CoffeeSize> builder)
    {
        base.Configure(builder);

        builder.ToTable("coffee_size");
    }
}
