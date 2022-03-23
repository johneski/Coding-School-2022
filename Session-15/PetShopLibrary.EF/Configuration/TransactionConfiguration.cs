using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(trans => trans.ID);
            builder.Property(trans => trans.TotalPrice).HasPrecision(7, 2);
            builder.Property(trans => trans.PetFoodPrice).HasPrecision(7, 2);
            builder.Property(trans => trans.PetPrice).HasPrecision(7, 2);

        }
    }
}
