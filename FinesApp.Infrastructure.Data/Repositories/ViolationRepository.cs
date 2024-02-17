using System;
using FinesApp.Domain.Entities;
using FinesApp.Domain.Interfaces.Repositories;
using FinesApp.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinesApp.Infrastructure.Data.Repositories
{
    public class ViolationRepository : IRepository<TypeOfMiolation>
    {
        protected readonly MiolationDbContext _dbContext;

        public ViolationRepository(DbContextOptions<MiolationDbContext> opt)
        {
            _dbContext = new MiolationDbContext(opt);
            _dbContext.Database.EnsureCreated();
            _dbContext.Miolations.Load();
        }

        public async Task InitializeAsync()
        {
            await _dbContext.Database.EnsureCreatedAsync();
            _dbContext.Miolations.Load();
        }

        public ViolationRepository(MiolationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ViolationRepository()
        {
            _dbContext = new MiolationDbContext();
        }

        public TypeOfMiolation GetById(int id)
        {
            return _dbContext.Miolations.Find(id);
        }

        public async Task<TypeOfMiolation> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Miolations.FindAsync(new object[] { id }, cancellationToken);
        }

        public IEnumerable<TypeOfMiolation> GetList()
        {
            return _dbContext.Miolations.ToList();
        }

        public async Task<IReadOnlyList<TypeOfMiolation>> GetListAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Miolations.AsNoTracking().ToListAsync(cancellationToken);
        }



        public void Add(TypeOfMiolation item)
        {        
            throw new Exception("ONLY READ");
        }

        public Task AddAsync(TypeOfMiolation item, CancellationToken cancellationToken = default)
        {
            throw new Exception("ONLY READ");
        }

        public void Delete(int id)
        {
            throw new Exception("ONLY READ");
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new Exception("ONLY READ");
        }

        public void Save()
        {
            throw new Exception("ONLY READ");
        }

        public Task SaveAsync(CancellationToken cancellationToken = default)
        {
            throw new Exception("ONLY READ");
        }

        public void Update(TypeOfMiolation item)
        {
            throw new Exception("ONLY READ");
        }

        public Task UpdateAsync(TypeOfMiolation item, CancellationToken cancellationToken = default)
        {
            throw new Exception("ONLY READ");
        }
    }
}
