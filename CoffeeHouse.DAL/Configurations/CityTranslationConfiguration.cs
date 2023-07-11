using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CityTranslationConfiguration : BaseConfiguration<CityTranslation>
{
    public override void Configure(EntityTypeBuilder<CityTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("city_translation");

        builder.Property(x => x.Name)
            .IsRequired()
            .IsUnicode(true)
            .HasMaxLength(256);
    }
}
