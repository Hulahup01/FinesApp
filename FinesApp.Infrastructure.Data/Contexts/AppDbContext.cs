using FinesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FinesApp.Infrastructure.Data.Contexts
{
    public class AppDbContext: DbContext
    {
        public DbSet<Driver> Drivers { get; set; }      
        public DbSet<RegistrationCertificate> RegistrationCertificates { get; set; }
        public DbSet<Fine> Fines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt)
        {

        }

        public AppDbContext()
        {

        }

    }
}
