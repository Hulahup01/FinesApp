using FinesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace FinesApp.Infrastructure.Data.Contexts
{
    public class MiolationDbContext: DbContext
    {
        public DbSet<TypeOfMiolation> Miolations { get; set; }

        public MiolationDbContext(DbContextOptions<MiolationDbContext> opt)
            : base(opt)
        {

        }

        public MiolationDbContext()
        {

        }
    }
}
