using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CoffeeCategoryTranslationConfigurtion : BaseConfiguration<CoffeeCategoryTranslation>
{
    public override void Configure(EntityTypeBuilder<CoffeeCategoryTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("coffee_category_translation");

        builder.Property(x => x.Name)
            .HasMaxLength(256)
            .IsRequired();

        builder.HasIndex(x => new { x.CoffeeCategoryId, x.LanguageId });
    }
}
