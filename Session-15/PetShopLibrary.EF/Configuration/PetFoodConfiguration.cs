using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.EF.Configuration
{
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.HasKey(food => food.ID);
            builder.Property(food => food.Type).IsRequired();
            builder.Property(food => food.Cost).IsRequired().HasPrecision(2);
            builder.Property(food => food.Price).IsRequired().HasPrecision(2);
            builder.Property(food => food.Brand).HasMaxLength(100);
        }
    }
}
