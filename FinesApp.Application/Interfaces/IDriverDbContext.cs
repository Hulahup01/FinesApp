using System;
using Microsoft.EntityFrameworkCore;
using FinesApp.Domain.Entities;

namespace FinesApp.Application.Interfaces
{
    public class IDriverDbContext
    {
        public DbSet<Driver> Users { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
