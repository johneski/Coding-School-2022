using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.EF.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(food => food.ID);
            builder.Property(food => food.Cost).IsRequired().HasPrecision(2);
            builder.Property(food => food.Price).IsRequired().HasPrecision(2);
            builder.Property(food => food.Breed).HasMaxLength(50);
        }
    }
}
