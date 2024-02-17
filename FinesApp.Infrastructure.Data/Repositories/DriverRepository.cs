using System;
using FinesApp.Domain.Entities;
using FinesApp.Domain.Interfaces.Repositories;
using FinesApp.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FinesApp.Infrastructure.Data.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        protected readonly AppDbContext _dbContext;

        public DriverRepository(DbContextOptions<AppDbContext> opt)
        {
            _dbContext = new AppDbContext(opt);
        }

        public DriverRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DriverRepository()
        {
            _dbContext = new AppDbContext();
        }

        public async Task InitializeAsync()
        {
            await _dbContext.Database.EnsureCreatedAsync();
            _dbContext.Drivers.Load();
        }

        public void Add(Driver item)
        {
            _dbContext.Drivers.Add(item);
        }

        public async Task AddAsync(Driver item, CancellationToken cancellationToken = default)
        {
            await _dbContext.Drivers.AddAsync(item, cancellationToken);
        }

        public void Delete(int id)
        {
            Driver? driver = _dbContext.Drivers.Find(id);
            if(driver != null)
                _dbContext.Drivers.Remove(driver);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            Driver? driver = await _dbContext.Drivers.FindAsync(new object[] { id }, cancellationToken);
            if (driver != null)
            {
                _dbContext.Drivers.Remove(driver);
            }
        }

        public Driver GetById(int id)
        {
            return _dbContext.Drivers.Find(id);
        }

        public async Task<Driver> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Drivers.FindAsync(new object[] { id }, cancellationToken);
        }

        public IEnumerable<Driver> GetList()
        {
            return _dbContext.Drivers.ToList();
        }

        public async Task<IReadOnlyList<Driver>> GetListAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Drivers.ToListAsync(cancellationToken);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    

        public void Update(Driver item)
        {
            _dbContext.Entry(item).State = EntityState.Modified; 
        }

        public Task UpdateAsync(Driver item, CancellationToken cancellationToken = default)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
            return Task.CompletedTask;
        }

    }
}
