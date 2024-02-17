using System;
using FinesApp.Domain.Entities;

namespace FinesApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Driver> DriverRepository { get; }
        IRepository<TypeOfMiolation> TraineeRepository { get; }
        public Task RemoveDatbaseAsync();
        public Task CreateDatabaseAsync();
        public Task SaveAllAsync();
    }

}
