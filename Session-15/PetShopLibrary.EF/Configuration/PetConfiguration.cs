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
            builder.HasKey(pet => pet.ID);
            builder.Property(pet => pet.Cost).IsRequired().HasPrecision(7,2);
            builder.Property(pet => pet.Price).IsRequired().HasPrecision(7,2);
            builder.Property(pet => pet.Breed).HasMaxLength(50);
        }
    }
}
