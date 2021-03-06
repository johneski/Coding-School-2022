using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.EF.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();
            builder.Property(employee => employee.Name).HasMaxLength(50);
            builder.Property(employee => employee.Surname).HasMaxLength(50);
            builder.Property(employee => employee.Salary).HasPrecision(7,2);
            builder.Property(employee => employee.EmpType).IsRequired();
        }
    }
}
