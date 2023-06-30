using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CoffeeTypeConfiguration : BaseConfiguration<CoffeeType>
{
    public override void Configure(EntityTypeBuilder<CoffeeType> builder)
    {
        base.Configure(builder);

        builder.ToTable("coffee_type");
    }
}
