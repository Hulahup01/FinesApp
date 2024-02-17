using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinesApp.Domain.Entities;

namespace FinesApp.Persistense.EntityTypeConfiguration
{
    public class DriverConfiguration: IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasKey(driver => driver.Id);
            builder.HasIndex(driver => driver.Id).IsUnique();    
        }
    }
}
