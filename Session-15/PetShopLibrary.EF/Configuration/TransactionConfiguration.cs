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
            builder.Property(trans => trans.CustomerID).IsRequired();
            builder.Property(trans => trans.EmployeeID).IsRequired();
            builder.Property(trans => trans.PetFoodID).IsRequired();
            builder.Property(trans => trans.PetID).IsRequired();
            builder.Property(trans => trans.PetFoodPrice).HasPrecision(2);
            builder.Property(trans => trans.PetPrice).HasPrecision(2);
            builder.Property(trans => trans.TotalPrice).HasPrecision(2);
        }
    }
}
