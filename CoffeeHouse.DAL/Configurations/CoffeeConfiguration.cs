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
    public class CoffeeConfiguration : BaseConfiguration<Coffee>
    {
        public override void Configure(EntityTypeBuilder<Coffee> builder)
        {
            base.Configure(builder);

            builder.ToTable("coffee");

            builder.Property(c => c.Price)
               .HasColumnType("decimal(18,2)");

            builder.HasIndex(x => x.CoffeeTypeId);
        }
    }
}
