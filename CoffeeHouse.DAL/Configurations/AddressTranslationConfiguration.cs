using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class AddressTranslationConfiguration : BaseConfiguration<AddressTranslation>
{
    public override void Configure(EntityTypeBuilder<AddressTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("address_translation");

        builder.Property(x => x.Street)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(x => x.State)
            .IsRequired()
            .HasMaxLength(256);
    }
}
