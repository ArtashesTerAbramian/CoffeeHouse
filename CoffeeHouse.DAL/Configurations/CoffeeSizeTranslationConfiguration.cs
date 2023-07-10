using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Configurations
{
    public class CoffeeSizeTranslationConfiguration : BaseConfiguration<CoffeeSizeTranslation>
    {
        public override void Configure(EntityTypeBuilder<CoffeeSizeTranslation> builder)
        {
            base.Configure(builder);

            builder.ToTable("coffee_size_translation");

            builder.Property(x => x.Size)
                .HasMaxLength(50);

            builder.HasIndex(x => x.CoffeeSizeId);
        }
    }
}
